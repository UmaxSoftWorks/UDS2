namespace Umax.Windows.Windows.Data
{
    partial class ItemEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainComboBox
            // 
            this.mainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainComboBox.FormattingEnabled = true;
            this.mainComboBox.Items.AddRange(new object[] {
            "WorkSpaces",
            "Tasks",
            "Keywords",
            "Text",
            "Images",
            "Templates",
            "Presets"});
            this.mainComboBox.Location = new System.Drawing.Point(12, 12);
            this.mainComboBox.Name = "mainComboBox";
            this.mainComboBox.Size = new System.Drawing.Size(207, 21);
            this.mainComboBox.TabIndex = 0;
            this.mainComboBox.SelectedIndexChanged += new System.EventHandler(this.mainComboBoxSelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(794, 352);
            this.mainPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.mainComboBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(794, 40);
            this.topPanel.TabIndex = 0;
            // 
            // ItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 392);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ItemEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemEditFormClosing);
            this.Load += new System.EventHandler(this.ItemEditLoad);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mainComboBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;

    }
}