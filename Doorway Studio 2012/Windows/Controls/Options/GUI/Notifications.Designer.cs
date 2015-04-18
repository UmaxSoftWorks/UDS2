namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiNotifications
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsGuiNotifications));
            this.actionPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.baloonsGroupBox = new System.Windows.Forms.GroupBox();
            this.baloonsShowTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baloonsShowTimeLabel = new System.Windows.Forms.Label();
            this.baloonsShowBaloonsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.baloonsShowBaloonsCheckBox = new System.Windows.Forms.CheckBox();
            this.soundsGroupBox = new System.Windows.Forms.GroupBox();
            this.soundsPlaySoundsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.soundsPlayTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.soundsPlayTimeLabel = new System.Windows.Forms.Label();
            this.soundsPlaySoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.soundsFilePanel = new System.Windows.Forms.Panel();
            this.soundsStopButton = new System.Windows.Forms.Button();
            this.soundsFileLabel = new System.Windows.Forms.Label();
            this.soundsFileTextBox = new System.Windows.Forms.TextBox();
            this.soundsPlayButton = new System.Windows.Forms.Button();
            this.soundsFileButton = new System.Windows.Forms.Button();
            this.soundsFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.actionPanel.SuspendLayout();
            this.baloonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baloonsShowTimeNumericUpDown)).BeginInit();
            this.soundsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundsPlayTimeNumericUpDown)).BeginInit();
            this.soundsFilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.applyButton);
            this.actionPanel.Controls.Add(this.cancelButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 326);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(530, 23);
            this.actionPanel.TabIndex = 4;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applyButton.Location = new System.Drawing.Point(380, 0);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(455, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // baloonsGroupBox
            // 
            this.baloonsGroupBox.Controls.Add(this.baloonsShowTimeNumericUpDown);
            this.baloonsGroupBox.Controls.Add(this.baloonsShowTimeLabel);
            this.baloonsGroupBox.Controls.Add(this.baloonsShowBaloonsCheckedListBox);
            this.baloonsGroupBox.Controls.Add(this.baloonsShowBaloonsCheckBox);
            this.baloonsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.baloonsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.baloonsGroupBox.Name = "baloonsGroupBox";
            this.baloonsGroupBox.Size = new System.Drawing.Size(530, 91);
            this.baloonsGroupBox.TabIndex = 5;
            this.baloonsGroupBox.TabStop = false;
            this.baloonsGroupBox.Text = "Baloons";
            // 
            // baloonsShowTimeNumericUpDown
            // 
            this.baloonsShowTimeNumericUpDown.Location = new System.Drawing.Point(6, 62);
            this.baloonsShowTimeNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.baloonsShowTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baloonsShowTimeNumericUpDown.Name = "baloonsShowTimeNumericUpDown";
            this.baloonsShowTimeNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.baloonsShowTimeNumericUpDown.TabIndex = 3;
            this.baloonsShowTimeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // baloonsShowTimeLabel
            // 
            this.baloonsShowTimeLabel.AutoSize = true;
            this.baloonsShowTimeLabel.Location = new System.Drawing.Point(6, 46);
            this.baloonsShowTimeLabel.Name = "baloonsShowTimeLabel";
            this.baloonsShowTimeLabel.Size = new System.Drawing.Size(82, 13);
            this.baloonsShowTimeLabel.TabIndex = 2;
            this.baloonsShowTimeLabel.Text = "Show time (sec)";
            // 
            // baloonsShowBaloonsCheckedListBox
            // 
            this.baloonsShowBaloonsCheckedListBox.CheckOnClick = true;
            this.baloonsShowBaloonsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.baloonsShowBaloonsCheckedListBox.FormattingEnabled = true;
            this.baloonsShowBaloonsCheckedListBox.Items.AddRange(new object[] {
            "Task started",
            "Task failed",
            "Task finished",
            "No new tasks"});
            this.baloonsShowBaloonsCheckedListBox.Location = new System.Drawing.Point(319, 16);
            this.baloonsShowBaloonsCheckedListBox.Name = "baloonsShowBaloonsCheckedListBox";
            this.baloonsShowBaloonsCheckedListBox.Size = new System.Drawing.Size(208, 72);
            this.baloonsShowBaloonsCheckedListBox.TabIndex = 1;
            // 
            // baloonsShowBaloonsCheckBox
            // 
            this.baloonsShowBaloonsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.baloonsShowBaloonsCheckBox.Name = "baloonsShowBaloonsCheckBox";
            this.baloonsShowBaloonsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.baloonsShowBaloonsCheckBox.TabIndex = 0;
            this.baloonsShowBaloonsCheckBox.Text = "Show baloons";
            this.baloonsShowBaloonsCheckBox.UseVisualStyleBackColor = true;
            this.baloonsShowBaloonsCheckBox.CheckedChanged += new System.EventHandler(this.baloonsShowBaloonsCheckBox_CheckedChanged);
            // 
            // soundsGroupBox
            // 
            this.soundsGroupBox.Controls.Add(this.soundsPlaySoundsCheckedListBox);
            this.soundsGroupBox.Controls.Add(this.soundsPlayTimeNumericUpDown);
            this.soundsGroupBox.Controls.Add(this.soundsPlayTimeLabel);
            this.soundsGroupBox.Controls.Add(this.soundsPlaySoundsCheckBox);
            this.soundsGroupBox.Controls.Add(this.soundsFilePanel);
            this.soundsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.soundsGroupBox.Location = new System.Drawing.Point(0, 91);
            this.soundsGroupBox.Name = "soundsGroupBox";
            this.soundsGroupBox.Size = new System.Drawing.Size(530, 123);
            this.soundsGroupBox.TabIndex = 6;
            this.soundsGroupBox.TabStop = false;
            this.soundsGroupBox.Text = "Sounds";
            // 
            // soundsPlaySoundsCheckedListBox
            // 
            this.soundsPlaySoundsCheckedListBox.CheckOnClick = true;
            this.soundsPlaySoundsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.soundsPlaySoundsCheckedListBox.FormattingEnabled = true;
            this.soundsPlaySoundsCheckedListBox.Items.AddRange(new object[] {
            "Task started",
            "Task failed",
            "Task finished",
            "No new tasks"});
            this.soundsPlaySoundsCheckedListBox.Location = new System.Drawing.Point(319, 16);
            this.soundsPlaySoundsCheckedListBox.Name = "soundsPlaySoundsCheckedListBox";
            this.soundsPlaySoundsCheckedListBox.Size = new System.Drawing.Size(208, 65);
            this.soundsPlaySoundsCheckedListBox.TabIndex = 6;
            this.soundsPlaySoundsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.soundsPlaySoundsCheckedListBox_SelectedIndexChanged);
            // 
            // soundsPlayTimeNumericUpDown
            // 
            this.soundsPlayTimeNumericUpDown.Location = new System.Drawing.Point(6, 55);
            this.soundsPlayTimeNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.soundsPlayTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soundsPlayTimeNumericUpDown.Name = "soundsPlayTimeNumericUpDown";
            this.soundsPlayTimeNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.soundsPlayTimeNumericUpDown.TabIndex = 5;
            this.soundsPlayTimeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // soundsPlayTimeLabel
            // 
            this.soundsPlayTimeLabel.AutoSize = true;
            this.soundsPlayTimeLabel.Location = new System.Drawing.Point(6, 39);
            this.soundsPlayTimeLabel.Name = "soundsPlayTimeLabel";
            this.soundsPlayTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.soundsPlayTimeLabel.TabIndex = 4;
            this.soundsPlayTimeLabel.Text = "Play time (sec)";
            // 
            // soundsPlaySoundsCheckBox
            // 
            this.soundsPlaySoundsCheckBox.AutoSize = true;
            this.soundsPlaySoundsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.soundsPlaySoundsCheckBox.Name = "soundsPlaySoundsCheckBox";
            this.soundsPlaySoundsCheckBox.Size = new System.Drawing.Size(83, 17);
            this.soundsPlaySoundsCheckBox.TabIndex = 0;
            this.soundsPlaySoundsCheckBox.Text = "Play sounds";
            this.soundsPlaySoundsCheckBox.UseVisualStyleBackColor = true;
            this.soundsPlaySoundsCheckBox.CheckedChanged += new System.EventHandler(this.soundsPlaySoundsCheckBox_CheckedChanged);
            // 
            // soundsFilePanel
            // 
            this.soundsFilePanel.Controls.Add(this.soundsStopButton);
            this.soundsFilePanel.Controls.Add(this.soundsFileLabel);
            this.soundsFilePanel.Controls.Add(this.soundsFileTextBox);
            this.soundsFilePanel.Controls.Add(this.soundsPlayButton);
            this.soundsFilePanel.Controls.Add(this.soundsFileButton);
            this.soundsFilePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.soundsFilePanel.Location = new System.Drawing.Point(3, 81);
            this.soundsFilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.soundsFilePanel.Name = "soundsFilePanel";
            this.soundsFilePanel.Size = new System.Drawing.Size(524, 39);
            this.soundsFilePanel.TabIndex = 11;
            // 
            // soundsStopButton
            // 
            this.soundsStopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundsStopButton.BackgroundImage")));
            this.soundsStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundsStopButton.Location = new System.Drawing.Point(481, 9);
            this.soundsStopButton.Name = "soundsStopButton";
            this.soundsStopButton.Size = new System.Drawing.Size(40, 23);
            this.soundsStopButton.TabIndex = 11;
            this.soundsStopButton.UseVisualStyleBackColor = true;
            this.soundsStopButton.Click += new System.EventHandler(this.soundsStopButton_Click);
            // 
            // soundsFileLabel
            // 
            this.soundsFileLabel.AutoSize = true;
            this.soundsFileLabel.Location = new System.Drawing.Point(3, 14);
            this.soundsFileLabel.Name = "soundsFileLabel";
            this.soundsFileLabel.Size = new System.Drawing.Size(23, 13);
            this.soundsFileLabel.TabIndex = 7;
            this.soundsFileLabel.Text = "File";
            // 
            // soundsFileTextBox
            // 
            this.soundsFileTextBox.Location = new System.Drawing.Point(32, 11);
            this.soundsFileTextBox.Name = "soundsFileTextBox";
            this.soundsFileTextBox.Size = new System.Drawing.Size(351, 20);
            this.soundsFileTextBox.TabIndex = 9;
            this.soundsFileTextBox.TextChanged += new System.EventHandler(this.soundsFileTextBox_TextChanged);
            // 
            // soundsPlayButton
            // 
            this.soundsPlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundsPlayButton.BackgroundImage")));
            this.soundsPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundsPlayButton.Location = new System.Drawing.Point(435, 9);
            this.soundsPlayButton.Name = "soundsPlayButton";
            this.soundsPlayButton.Size = new System.Drawing.Size(40, 23);
            this.soundsPlayButton.TabIndex = 10;
            this.soundsPlayButton.UseVisualStyleBackColor = true;
            this.soundsPlayButton.Click += new System.EventHandler(this.soundsPlayButton_Click);
            // 
            // soundsFileButton
            // 
            this.soundsFileButton.Location = new System.Drawing.Point(389, 9);
            this.soundsFileButton.Name = "soundsFileButton";
            this.soundsFileButton.Size = new System.Drawing.Size(40, 23);
            this.soundsFileButton.TabIndex = 8;
            this.soundsFileButton.Text = "...";
            this.soundsFileButton.UseVisualStyleBackColor = true;
            this.soundsFileButton.Click += new System.EventHandler(this.soundsFileButton_Click);
            // 
            // soundsFileOpenFileDialog
            // 
            this.soundsFileOpenFileDialog.Filter = "All|*.*";
            // 
            // OptionsGuiNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soundsGroupBox);
            this.Controls.Add(this.baloonsGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsGuiNotifications";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiNotificationsLoad);
            this.actionPanel.ResumeLayout(false);
            this.baloonsGroupBox.ResumeLayout(false);
            this.baloonsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baloonsShowTimeNumericUpDown)).EndInit();
            this.soundsGroupBox.ResumeLayout(false);
            this.soundsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundsPlayTimeNumericUpDown)).EndInit();
            this.soundsFilePanel.ResumeLayout(false);
            this.soundsFilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox baloonsGroupBox;
        private System.Windows.Forms.GroupBox soundsGroupBox;
        private System.Windows.Forms.CheckBox baloonsShowBaloonsCheckBox;
        private System.Windows.Forms.CheckedListBox baloonsShowBaloonsCheckedListBox;
        private System.Windows.Forms.NumericUpDown baloonsShowTimeNumericUpDown;
        private System.Windows.Forms.Label baloonsShowTimeLabel;
        private System.Windows.Forms.CheckBox soundsPlaySoundsCheckBox;
        private System.Windows.Forms.TextBox soundsFileTextBox;
        private System.Windows.Forms.Button soundsFileButton;
        private System.Windows.Forms.Label soundsFileLabel;
        private System.Windows.Forms.CheckedListBox soundsPlaySoundsCheckedListBox;
        private System.Windows.Forms.OpenFileDialog soundsFileOpenFileDialog;
        private System.Windows.Forms.Button soundsPlayButton;
        private System.Windows.Forms.Panel soundsFilePanel;
        private System.Windows.Forms.Button soundsStopButton;
        private System.Windows.Forms.NumericUpDown soundsPlayTimeNumericUpDown;
        private System.Windows.Forms.Label soundsPlayTimeLabel;
    }
}
