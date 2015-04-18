using Umax.Windows.Tools.TemplateEditor.UI;

namespace Umax.Windows.Tools.TemplateEditor.Controls
{
    partial class TextEditorControl
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
            this.mainTrackBar = new System.Windows.Forms.TrackBar();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.savePathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelPathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.importToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.importANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.exportANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportUTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.decreaseIndentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.increaseIndentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainRichTextBox = new Umax.Windows.Tools.TemplateEditor.UI.IntellisenseRichTextBox();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainTrackBar)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTrackBar
            // 
            this.mainTrackBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainTrackBar.LargeChange = 100;
            this.mainTrackBar.Location = new System.Drawing.Point(196, 0);
            this.mainTrackBar.Maximum = 500;
            this.mainTrackBar.Minimum = 100;
            this.mainTrackBar.Name = "mainTrackBar";
            this.mainTrackBar.Size = new System.Drawing.Size(104, 20);
            this.mainTrackBar.SmallChange = 10;
            this.mainTrackBar.TabIndex = 1;
            this.mainTrackBar.TickFrequency = 10;
            this.mainTrackBar.Value = 100;
            this.mainTrackBar.Scroll += new System.EventHandler(this.mainTrackBarScroll);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.pathTextBox);
            this.bottomPanel.Controls.Add(this.bottomToolStrip);
            this.bottomPanel.Controls.Add(this.mainTrackBar);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 280);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(300, 20);
            this.bottomPanel.TabIndex = 2;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(0, 0);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(149, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePathToolStripButton,
            this.cancelPathToolStripButton});
            this.bottomToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.bottomToolStrip.Location = new System.Drawing.Point(149, 0);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bottomToolStrip.Size = new System.Drawing.Size(47, 20);
            this.bottomToolStrip.TabIndex = 2;
            // 
            // savePathToolStripButton
            // 
            this.savePathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savePathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savePathToolStripButton.Name = "savePathToolStripButton";
            this.savePathToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.savePathToolStripButton.Text = "Save";
            this.savePathToolStripButton.Click += new System.EventHandler(this.SaveItemPath);
            // 
            // cancelPathToolStripButton
            // 
            this.cancelPathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelPathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelPathToolStripButton.Name = "cancelPathToolStripButton";
            this.cancelPathToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.cancelPathToolStripButton.Text = "Cancel";
            this.cancelPathToolStripButton.Click += new System.EventHandler(this.CancelItemPath);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripSplitButton,
            this.exportToolStripSplitButton,
            this.toolStripSeparator1,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator2,
            this.decreaseIndentToolStripButton,
            this.increaseIndentToolStripButton});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(300, 23);
            this.mainToolStrip.TabIndex = 3;
            // 
            // importToolStripSplitButton
            // 
            this.importToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importANSIToolStripMenuItem,
            this.importUTF8ToolStripMenuItem});
            this.importToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripSplitButton.Name = "importToolStripSplitButton";
            this.importToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.importToolStripSplitButton.Text = "Import";
            // 
            // importANSIToolStripMenuItem
            // 
            this.importANSIToolStripMenuItem.Name = "importANSIToolStripMenuItem";
            this.importANSIToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.importANSIToolStripMenuItem.Text = "ANSI";
            this.importANSIToolStripMenuItem.Click += new System.EventHandler(this.ImportANSI);
            // 
            // importUTF8ToolStripMenuItem
            // 
            this.importUTF8ToolStripMenuItem.Name = "importUTF8ToolStripMenuItem";
            this.importUTF8ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.importUTF8ToolStripMenuItem.Text = "UTF-8";
            this.importUTF8ToolStripMenuItem.Click += new System.EventHandler(this.ImportUTF8);
            // 
            // exportToolStripSplitButton
            // 
            this.exportToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportANSIToolStripMenuItem,
            this.exportUTF8ToolStripMenuItem});
            this.exportToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripSplitButton.Name = "exportToolStripSplitButton";
            this.exportToolStripSplitButton.Size = new System.Drawing.Size(16, 4);
            this.exportToolStripSplitButton.Text = "Export";
            // 
            // exportANSIToolStripMenuItem
            // 
            this.exportANSIToolStripMenuItem.Name = "exportANSIToolStripMenuItem";
            this.exportANSIToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportANSIToolStripMenuItem.Text = "ANSI";
            this.exportANSIToolStripMenuItem.Click += new System.EventHandler(this.ExportANSI);
            // 
            // exportUTF8ToolStripMenuItem
            // 
            this.exportUTF8ToolStripMenuItem.Name = "exportUTF8ToolStripMenuItem";
            this.exportUTF8ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportUTF8ToolStripMenuItem.Text = "UTF-8";
            this.exportUTF8ToolStripMenuItem.Click += new System.EventHandler(this.ExportUTF8);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.Click += new System.EventHandler(this.Cut);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.Copy);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.Paste);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // decreaseIndentToolStripButton
            // 
            this.decreaseIndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseIndentToolStripButton.Name = "decreaseIndentToolStripButton";
            this.decreaseIndentToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.decreaseIndentToolStripButton.Text = "Decrease Indent";
            this.decreaseIndentToolStripButton.Click += new System.EventHandler(this.DecreaseIndent);
            // 
            // increaseIndentToolStripButton
            // 
            this.increaseIndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseIndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseIndentToolStripButton.Name = "increaseIndentToolStripButton";
            this.increaseIndentToolStripButton.Size = new System.Drawing.Size(23, 4);
            this.increaseIndentToolStripButton.Text = "Increase Indent";
            this.increaseIndentToolStripButton.Click += new System.EventHandler(this.IncreaseIndent);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.AcceptsTab = true;
            this.mainRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRichTextBox.Location = new System.Drawing.Point(0, 23);
            this.mainRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.NumberAlignment = System.Drawing.StringAlignment.Near;
            this.mainRichTextBox.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.mainRichTextBox.NumberBackground2 = System.Drawing.SystemColors.ControlLight;
            this.mainRichTextBox.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.mainRichTextBox.NumberBorderThickness = 0F;
            this.mainRichTextBox.NumberColor = System.Drawing.Color.DarkGray;
            this.mainRichTextBox.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRichTextBox.NumberLeadingZeroes = false;
            this.mainRichTextBox.NumberLineCounting = Umax.UI.XPRichTextBox.Enums.LineCounting.AsDisplayed;
            this.mainRichTextBox.NumberPadding = 0;
            this.mainRichTextBox.ShowLineNumbers = true;
            this.mainRichTextBox.Size = new System.Drawing.Size(300, 257);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            this.mainRichTextBox.Tokens = null;
            this.mainRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainRichTextBoxKeyDown);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Text|*.txt|HTML|*.html|All|*.*";
            // 
            // mainSaveFileDialog
            // 
            this.mainSaveFileDialog.Filter = "Text|*.txt|HTML|*.html|All|*.*";
            // 
            // TextEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.bottomPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TextEditorControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.TextEditorControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mainTrackBar)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar mainTrackBar;
        private System.Windows.Forms.Panel bottomPanel;
        protected System.Windows.Forms.TextBox pathTextBox;
        protected System.Windows.Forms.ToolStrip bottomToolStrip;
        protected System.Windows.Forms.ToolStripButton savePathToolStripButton;
        protected System.Windows.Forms.ToolStripButton cancelPathToolStripButton;
        private IntellisenseRichTextBox mainRichTextBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripSplitButton importToolStripSplitButton;
        private System.Windows.Forms.ToolStripSplitButton exportToolStripSplitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton decreaseIndentToolStripButton;
        private System.Windows.Forms.ToolStripButton increaseIndentToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem importANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importUTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUTF8ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog mainSaveFileDialog;
    }
}
