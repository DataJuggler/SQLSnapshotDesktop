

#region using statements


#endregion

namespace SQLSnapshotDesktop
{

    #region class MainForm
    /// <summary>
    /// This class is the designer for this file.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl PathControl;
        private DataJuggler.Win.Controls.Button ExportButton;
        private PictureBox CompleteImage;
        private System.Windows.Forms.Timer Timer;
        private DataJuggler.Win.Controls.LabelTextBoxControl ConnectionTextBox;
        private DataJuggler.Win.Controls.LabelTextBoxControl IgnoreTablesTextBox;
        private Label InfoLabel;
        private DataJuggler.Win.Controls.Objects.PanelExtender ProgressPanel;
        private Label CurrentStatusLabel;
        private ProgressBar CurrentProgressGraph;
        private Label OverallStatusLabel;
        private ProgressBar OverallProgressGraph;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                PathControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
                ExportButton = new DataJuggler.Win.Controls.Button();
                CompleteImage = new PictureBox();
                Timer = new System.Windows.Forms.Timer(components);
                ConnectionTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
                IgnoreTablesTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
                InfoLabel = new Label();
                ProgressPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
                CurrentStatusLabel = new Label();
                CurrentProgressGraph = new ProgressBar();
                OverallStatusLabel = new Label();
                OverallProgressGraph = new ProgressBar();
                ((System.ComponentModel.ISupportInitialize)CompleteImage).BeginInit();
                ProgressPanel.SuspendLayout();
                SuspendLayout();
                //
                // PathControl
                //
                PathControl.BackColor = Color.Transparent;
                PathControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
                PathControl.ButtonColor = Color.LemonChiffon;
                PathControl.ButtonImage = (Image)resources.GetObject("PathControl.ButtonImage");
                PathControl.ButtonWidth = 48;
                PathControl.DarkMode = false;
                PathControl.DisabledLabelColor = Color.Empty;
                PathControl.Editable = true;
                PathControl.EnabledLabelColor = Color.Empty;
                PathControl.Filter = null;
                PathControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
                PathControl.HideBrowseButton = false;
                PathControl.LabelBottomMargin = 0;
                PathControl.LabelColor = Color.LemonChiffon;
                PathControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                PathControl.LabelText = "Path:";
                PathControl.LabelTopMargin = 0;
                PathControl.LabelWidth = 140;
                PathControl.Location = new Point(53, 93);
                PathControl.Name = "PathControl";
                PathControl.OnTextChangedListener = null;
                PathControl.OpenCallback = null;
                PathControl.ScrollBars = ScrollBars.None;
                PathControl.SelectedPath = null;
                PathControl.Size = new Size(688, 32);
                PathControl.StartPath = null;
                PathControl.TabIndex = 1;
                PathControl.TextBoxBottomMargin = 0;
                PathControl.TextBoxDisabledColor = Color.Empty;
                PathControl.TextBoxEditableColor = Color.Empty;
                PathControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
                PathControl.TextBoxTopMargin = 0;
                PathControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // ExportButton
                //
                ExportButton.BackColor = Color.Transparent;
                ExportButton.ButtonText = "Export";
                ExportButton.FlatStyle = FlatStyle.Flat;
                ExportButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                ExportButton.ForeColor = Color.LemonChiffon;
                ExportButton.Location = new Point(603, 199);
                ExportButton.Margin = new Padding(5, 4, 5, 4);
                ExportButton.Name = "ExportButton";
                ExportButton.Size = new Size(138, 53);
                ExportButton.TabIndex = 2;
                ExportButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                ExportButton.Click += ExportButton_Click;
                //
                // CompleteImage
                //
                CompleteImage.BackgroundImage = Properties.Resources.Complete;
                CompleteImage.BackgroundImageLayout = ImageLayout.Stretch;
                CompleteImage.Location = new Point(386, 200);
                CompleteImage.Name = "CompleteImage";
                CompleteImage.Size = new Size(151, 50);
                CompleteImage.TabIndex = 3;
                CompleteImage.TabStop = false;
                CompleteImage.Visible = false;
                //
                // Timer
                //
                Timer.Interval = 3000;
                Timer.Tick += Timer_Tick;
                //
                // ConnectionTextBox
                //
                ConnectionTextBox.BackColor = Color.Transparent;
                ConnectionTextBox.BottomMargin = 0;
                ConnectionTextBox.Editable = true;
                ConnectionTextBox.Encrypted = false;
                ConnectionTextBox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                ConnectionTextBox.Inititialized = true;
                ConnectionTextBox.LabelBottomMargin = 0;
                ConnectionTextBox.LabelColor = Color.LemonChiffon;
                ConnectionTextBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                ConnectionTextBox.LabelText = "Conn String:";
                ConnectionTextBox.LabelTopMargin = 0;
                ConnectionTextBox.LabelWidth = 140;
                ConnectionTextBox.Location = new Point(53, 40);
                ConnectionTextBox.MultiLine = false;
                ConnectionTextBox.Name = "ConnectionTextBox";
                ConnectionTextBox.OnTextChangedListener = null;
                ConnectionTextBox.PasswordMode = false;
                ConnectionTextBox.ScrollBars = ScrollBars.None;
                ConnectionTextBox.Size = new Size(688, 32);
                ConnectionTextBox.TabIndex = 0;
                ConnectionTextBox.TextBoxBottomMargin = 0;
                ConnectionTextBox.TextBoxDisabledColor = Color.LightGray;
                ConnectionTextBox.TextBoxEditableColor = Color.White;
                ConnectionTextBox.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
                ConnectionTextBox.TextBoxTopMargin = 0;
                ConnectionTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // IgnoreTablesTextBox
                //
                IgnoreTablesTextBox.BackColor = Color.Transparent;
                IgnoreTablesTextBox.BottomMargin = 0;
                IgnoreTablesTextBox.Editable = true;
                IgnoreTablesTextBox.Encrypted = false;
                IgnoreTablesTextBox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                IgnoreTablesTextBox.Inititialized = true;
                IgnoreTablesTextBox.LabelBottomMargin = 0;
                IgnoreTablesTextBox.LabelColor = Color.LemonChiffon;
                IgnoreTablesTextBox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
                IgnoreTablesTextBox.LabelText = "Ignore Tables:";
                IgnoreTablesTextBox.LabelTopMargin = 0;
                IgnoreTablesTextBox.LabelWidth = 140;
                IgnoreTablesTextBox.Location = new Point(53, 146);
                IgnoreTablesTextBox.MultiLine = false;
                IgnoreTablesTextBox.Name = "IgnoreTablesTextBox";
                IgnoreTablesTextBox.OnTextChangedListener = null;
                IgnoreTablesTextBox.PasswordMode = false;
                IgnoreTablesTextBox.ScrollBars = ScrollBars.None;
                IgnoreTablesTextBox.Size = new Size(688, 32);
                IgnoreTablesTextBox.TabIndex = 4;
                IgnoreTablesTextBox.TextBoxBottomMargin = 0;
                IgnoreTablesTextBox.TextBoxDisabledColor = Color.LightGray;
                IgnoreTablesTextBox.TextBoxEditableColor = Color.White;
                IgnoreTablesTextBox.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
                IgnoreTablesTextBox.TextBoxTopMargin = 0;
                IgnoreTablesTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // InfoLabel
                //
                InfoLabel.BackColor = Color.Transparent;
                InfoLabel.ForeColor = Color.LemonChiffon;
                InfoLabel.Location = new Point(53, 185);
                InfoLabel.Name = "InfoLabel";
                InfoLabel.Size = new Size(301, 71);
                InfoLabel.TabIndex = 5;
                InfoLabel.Text = "Comma delimited list of strings.\r\n\r\nExample: Users, Admin, ActivityLog";
                //
                // ProgressPanel
                //
                ProgressPanel.BackColor = Color.Transparent;
                ProgressPanel.Controls.Add(CurrentStatusLabel);
                ProgressPanel.Controls.Add(CurrentProgressGraph);
                ProgressPanel.Controls.Add(OverallStatusLabel);
                ProgressPanel.Controls.Add(OverallProgressGraph);
                ProgressPanel.Location = new Point(34, 268);
                ProgressPanel.Name = "ProgressPanel";
                ProgressPanel.Size = new Size(754, 159);
                ProgressPanel.TabIndex = 10;
                ProgressPanel.Visible = false;
                //
                // CurrentStatusLabel
                //
                CurrentStatusLabel.BackColor = Color.Transparent;
                CurrentStatusLabel.ForeColor = Color.LemonChiffon;
                CurrentStatusLabel.Location = new Point(17, 93);
                CurrentStatusLabel.Name = "CurrentStatusLabel";
                CurrentStatusLabel.Size = new Size(720, 24);
                CurrentStatusLabel.TabIndex = 13;
                CurrentStatusLabel.Text = "Current Status:\r\n";
                CurrentStatusLabel.TextAlign = ContentAlignment.BottomLeft;
                //
                // CurrentProgressGraph
                //
                CurrentProgressGraph.Location = new Point(17, 121);
                CurrentProgressGraph.Name = "CurrentProgressGraph";
                CurrentProgressGraph.Size = new Size(720, 22);
                CurrentProgressGraph.TabIndex = 12;
                //
                // OverallStatusLabel
                //
                OverallStatusLabel.BackColor = Color.Transparent;
                OverallStatusLabel.ForeColor = Color.LemonChiffon;
                OverallStatusLabel.Location = new Point(17, 15);
                OverallStatusLabel.Name = "OverallStatusLabel";
                OverallStatusLabel.Size = new Size(720, 24);
                OverallStatusLabel.TabIndex = 11;
                OverallStatusLabel.Text = "Overall Status:\r\n";
                OverallStatusLabel.TextAlign = ContentAlignment.BottomLeft;
                //
                // OverallProgressGraph
                //
                OverallProgressGraph.Location = new Point(17, 43);
                OverallProgressGraph.Name = "OverallProgressGraph";
                OverallProgressGraph.Size = new Size(720, 22);
                OverallProgressGraph.TabIndex = 10;
                //
                // MainForm
                //
                AutoScaleMode = AutoScaleMode.None;
                BackgroundImage = Properties.Resources.Black_Textured;
                BackgroundImageLayout = ImageLayout.Stretch;
                ClientSize = new Size(800, 439);
                Controls.Add(ProgressPanel);
                Controls.Add(InfoLabel);
                Controls.Add(IgnoreTablesTextBox);
                Controls.Add(CompleteImage);
                Controls.Add(ExportButton);
                Controls.Add(PathControl);
                Controls.Add(ConnectionTextBox);
                DoubleBuffered = true;
                Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
                Icon = (Icon)resources.GetObject("$this.Icon");
                Name = "MainForm";
                StartPosition = FormStartPosition.CenterScreen;
                Text = "SQL Snapshot Desktop";
                ((System.ComponentModel.ISupportInitialize)CompleteImage).EndInit();
                ProgressPanel.ResumeLayout(false);
                ResumeLayout(false);
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
