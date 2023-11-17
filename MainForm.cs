

#region using statements

using DataJuggler.SQLSnapshot;
using DataJuggler.NET8;
using DataJuggler.NET8.Delegates;

#endregion

namespace SQLSnapshotDesktop
{

    #region class MainForm
    /// <summary>
    /// This class is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion

        #region Events

        #region ExportButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'ExportButton' is clicked.
        /// </summary>
        private void ExportButton_Click(object sender, EventArgs e)
        {
            // Set the connection string
            string connectionString = ConnectionTextBox.Text;

            // Set the path
            string path = PathControl.Text;

            // Parse the list of strings to ignore tables
            List<string> ignoreTables = IgnoreTablesTextBox.Text.Split(',').ToList();

            // Show the ProgressPanel
            ProgressPanel.Visible = true;

            // Update
            Refresh();
            Application.DoEvents();

            // Set the result
            SQLExportResult result = SQLExcelBridge.ExportSnapshot(connectionString, path, ignoreTables, ProgressUpdate);

            // Show
            CompleteImage.Visible = true;

            // Show the ProgressPanel
            ProgressPanel.Visible = false;

            // Update
            Refresh();
            Application.DoEvents();

            // Start the timer
            Timer.Start();
        }
        #endregion

        #region Timer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Timer _ Tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Only run once
            Timer.Stop();

            // hide
            CompleteImage.Visible = false;
        }
        #endregion

        #endregion

        #region Methods

        #region ProgressUpdate(int overallMax, int overallCurrentValue, string overallStatus, int currentMax, int currentValue, string currentStatus)
        /// <summary>
        /// This method is used as a Callback for the ProgressStatusCallback
        /// </summary>
        public void ProgressUpdate(int overallMax, int overallCurrentValue, string overallStatus, int currentMax, int currentValue, string currentStatus)
        {
            // safeguards
            if (overallCurrentValue > overallMax)
            {
                // Safeguard against progress bar overflow
                overallCurrentValue = overallMax;
            }

            // safeguard
            if (currentValue > currentMax)
            {
                // Safeguard against progress bar overflow
                currentValue = currentMax;
            }

            // overall
            OverallProgressGraph.Maximum = overallMax;
            OverallProgressGraph.Value = overallCurrentValue;
            OverallStatusLabel.Text = overallStatus;

            // current
            CurrentProgressGraph.Maximum = currentMax;
            CurrentProgressGraph.Value = currentValue;
            CurrentStatusLabel.Text = currentStatus;

            // Update the UI
            Refresh();
            Application.DoEvents();
        }
        #endregion

        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
