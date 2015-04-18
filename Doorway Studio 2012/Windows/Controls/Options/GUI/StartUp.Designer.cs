namespace Umax.Windows.Controls.Options.GUI
{
    partial class OptionsGuiStartUp
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.generalAutoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.generalMinimizedStartCheckBox = new System.Windows.Forms.CheckBox();
            this.actionPanel.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
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
            this.actionPanel.TabIndex = 3;
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
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
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
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.generalAutoStartCheckBox);
            this.generalGroupBox.Controls.Add(this.generalMinimizedStartCheckBox);
            this.generalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalGroupBox.Location = new System.Drawing.Point(0, 0);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(530, 69);
            this.generalGroupBox.TabIndex = 4;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // generalAutoStartCheckBox
            // 
            this.generalAutoStartCheckBox.AutoSize = true;
            this.generalAutoStartCheckBox.Location = new System.Drawing.Point(6, 42);
            this.generalAutoStartCheckBox.Name = "generalAutoStartCheckBox";
            this.generalAutoStartCheckBox.Size = new System.Drawing.Size(117, 17);
            this.generalAutoStartCheckBox.TabIndex = 1;
            this.generalAutoStartCheckBox.Text = "Start with Windows";
            this.generalAutoStartCheckBox.UseVisualStyleBackColor = true;
            this.generalAutoStartCheckBox.CheckedChanged += new System.EventHandler(this.generalAutoStartCheckBox_CheckedChanged);
            // 
            // generalMinimizedStartCheckBox
            // 
            this.generalMinimizedStartCheckBox.AutoSize = true;
            this.generalMinimizedStartCheckBox.Location = new System.Drawing.Point(6, 19);
            this.generalMinimizedStartCheckBox.Name = "generalMinimizedStartCheckBox";
            this.generalMinimizedStartCheckBox.Size = new System.Drawing.Size(95, 17);
            this.generalMinimizedStartCheckBox.TabIndex = 0;
            this.generalMinimizedStartCheckBox.Text = "Minimized start";
            this.generalMinimizedStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsGuiStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.actionPanel);
            this.Name = "OptionsGuiStartUp";
            this.Size = new System.Drawing.Size(530, 349);
            this.Load += new System.EventHandler(this.OptionsGuiStartUp_Load);
            this.actionPanel.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox generalMinimizedStartCheckBox;
        private System.Windows.Forms.CheckBox generalAutoStartCheckBox;
    }
}
