namespace Umax.Windows.Tools.Automator.Pro
{
    partial class AutomatorPro
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
            this.automatorPropertyGrid = new Umax.Windows.Tools.Automator.UI.AutomatorPropertyGrid();
            this.SuspendLayout();
            // 
            // automatorPropertyGrid
            // 
            this.automatorPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.automatorPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.automatorPropertyGrid.Name = "automatorPropertyGrid";
            this.automatorPropertyGrid.Size = new System.Drawing.Size(778, 354);
            this.automatorPropertyGrid.TabIndex = 1;
            // 
            // AutomatorPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 354);
            this.Controls.Add(this.automatorPropertyGrid);
            this.Name = "AutomatorPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doorway Studio 2012: Automator Pro";
            this.Load += new System.EventHandler(this.AutomatorProLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.AutomatorPropertyGrid automatorPropertyGrid;
    }
}