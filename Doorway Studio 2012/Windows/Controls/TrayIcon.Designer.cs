namespace Umax.Windows.Controls
{
    partial class TrayIcon
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
            this.components = new System.ComponentModel.Container();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.workSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workSpaceNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workSpaceEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksDeleteNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksDeleteCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksDeleteFailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksDeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsInternalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsInternalTemplateEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsInternalAutomatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsInternalAutomatorProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExternalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExternalKeywordMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExternalKeywordMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExternalKeywordSelectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsExternalTextCleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsExternalTextFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsExternalDetailsIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryWorkSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsHistoryKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsHistoryPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextMenuStrip.SuspendLayout();
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.Visible = true;
            this.mainNotifyIcon.DoubleClick += this.IconDoubleClick;
            this.mainNotifyIcon.Click += this.IconClick;
            this.mainNotifyIcon.ContextMenuStrip = this.mainContextMenuStrip;
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.toolStripSeparator1,
            this.workSpaceToolStripMenuItem,
            this.toolStripSeparator3,
            this.tasksToolStripMenuItem,
            this.toolStripSeparator7,
            this.dataToolStripMenuItem,
            this.toolStripSeparator8,
            this.historyToolStripMenuItem,
            this.toolStripSeparator9,
            this.toolsToolStripMenuItem,
            this.toolStripSeparator15,
            this.windowsToolStripMenuItem,
            this.toolStripSeparator17,
            this.exitToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainNotifyIconContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(153, 216);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += this.ShowWindow;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // workSpaceToolStripMenuItem
            // 
            this.workSpaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workSpaceNewToolStripMenuItem,
            this.toolStripSeparator2,
            this.workSpaceEditToolStripMenuItem});
            this.workSpaceToolStripMenuItem.Name = "workSpaceToolStripMenuItem";
            this.workSpaceToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.workSpaceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workSpaceToolStripMenuItem.Text = "&WorkSpace";
            // 
            // workSpaceNewToolStripMenuItem
            // 
            this.workSpaceNewToolStripMenuItem.Name = "workSpaceNewToolStripMenuItem";
            this.workSpaceNewToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.workSpaceNewToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.workSpaceNewToolStripMenuItem.Text = "New";
            this.workSpaceNewToolStripMenuItem.Click += this.CreateWorkSpace;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(95, 6);
            // 
            // workSpaceEditToolStripMenuItem
            // 
            this.workSpaceEditToolStripMenuItem.Name = "workSpaceEditToolStripMenuItem";
            this.workSpaceEditToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.workSpaceEditToolStripMenuItem.Text = "Edit";
            this.workSpaceEditToolStripMenuItem.Click += this.EditWorkSpaces;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksNewToolStripMenuItem,
            this.toolStripSeparator4,
            this.tasksEditToolStripMenuItem,
            this.toolStripSeparator5,
            this.tasksDeleteToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tasksToolStripMenuItem.Text = "&Tasks";
            // 
            // tasksNewToolStripMenuItem
            // 
            this.tasksNewToolStripMenuItem.Name = "iconTasksNewToolStripMenuItem";
            this.tasksNewToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.tasksNewToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tasksNewToolStripMenuItem.Text = "&New";
            this.tasksNewToolStripMenuItem.Click += this.CreateTask;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(104, 6);
            // 
            // tasksEditToolStripMenuItem
            // 
            this.tasksEditToolStripMenuItem.Name = "iconTasksEditToolStripMenuItem";
            this.tasksEditToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.tasksEditToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tasksEditToolStripMenuItem.Text = "&Edit";
            this.tasksEditToolStripMenuItem.Click += this.EditTasks;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "zzzToolStripSeparator204";
            this.toolStripSeparator5.Size = new System.Drawing.Size(104, 6);
            // 
            // tasksDeleteToolStripMenuItem
            // 
            this.tasksDeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksDeleteNewToolStripMenuItem,
            this.tasksDeleteCompletedToolStripMenuItem,
            this.tasksDeleteFailedToolStripMenuItem,
            this.toolStripSeparator6,
            this.tasksDeleteAllToolStripMenuItem});
            this.tasksDeleteToolStripMenuItem.Name = "tasksDeleteToolStripMenuItem";
            this.tasksDeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tasksDeleteToolStripMenuItem.Text = "Delete";
            // 
            // tasksDeleteNewToolStripMenuItem
            // 
            this.tasksDeleteNewToolStripMenuItem.Name = "tasksDeleteNewToolStripMenuItem";
            this.tasksDeleteNewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tasksDeleteNewToolStripMenuItem.Text = "New";
            this.tasksDeleteNewToolStripMenuItem.Click += this.DeleteNewTasks;
            // 
            // tasksDeleteCompletedToolStripMenuItem
            // 
            this.tasksDeleteCompletedToolStripMenuItem.Name = "tasksDeleteCompletedToolStripMenuItem";
            this.tasksDeleteCompletedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tasksDeleteCompletedToolStripMenuItem.Text = "Completed";
            this.tasksDeleteCompletedToolStripMenuItem.Click += this.DeleteCompletedTasks;
            // 
            // tasksDeleteFailedToolStripMenuItem
            // 
            this.tasksDeleteFailedToolStripMenuItem.Name = "iconTasksDeleteFailedToolStripMenuItem";
            this.tasksDeleteFailedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tasksDeleteFailedToolStripMenuItem.Text = "Failed";
            this.tasksDeleteFailedToolStripMenuItem.Click += this.DeleteFailedTasks;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(130, 6);
            // 
            // tasksDeleteAllToolStripMenuItem
            // 
            this.tasksDeleteAllToolStripMenuItem.Name = "tasksDeleteAllToolStripMenuItem";
            this.tasksDeleteAllToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tasksDeleteAllToolStripMenuItem.Text = "All";
            this.tasksDeleteAllToolStripMenuItem.Click += this.DeleteAllTasks;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataKeywordsToolStripMenuItem,
            this.dataTextToolStripMenuItem,
            this.dataImagesToolStripMenuItem,
            this.dataTemplatesToolStripMenuItem,
            this.dataPresetsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // dataKeywordsToolStripMenuItem
            // 
            this.dataKeywordsToolStripMenuItem.Name = "dataKeywordsToolStripMenuItem";
            this.dataKeywordsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataKeywordsToolStripMenuItem.Text = "&Keywords";
            this.dataKeywordsToolStripMenuItem.Click += this.EditKeywords;
            // 
            // dataTextToolStripMenuItem
            // 
            this.dataTextToolStripMenuItem.Name = "dataTextToolStripMenuItem";
            this.dataTextToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataTextToolStripMenuItem.Text = "T&ext";
            this.dataTextToolStripMenuItem.Click += this.EditText;
            // 
            // dataImagesToolStripMenuItem
            // 
            this.dataImagesToolStripMenuItem.Name = "dataImagesToolStripMenuItem";
            this.dataImagesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataImagesToolStripMenuItem.Text = "&Images";
            this.dataImagesToolStripMenuItem.Click += this.EditImages;
            // 
            // dataTemplatesToolStripMenuItem
            // 
            this.dataTemplatesToolStripMenuItem.Name = "dataTemplatesToolStripMenuItem";
            this.dataTemplatesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataTemplatesToolStripMenuItem.Text = "Te&mplates";
            this.dataTemplatesToolStripMenuItem.Click += this.EditTemplates;
            // 
            // dataPresetsToolStripMenuItem
            // 
            this.dataPresetsToolStripMenuItem.Name = "dataPresetsToolStripMenuItem";
            this.dataPresetsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataPresetsToolStripMenuItem.Text = "&Presets";
            this.dataPresetsToolStripMenuItem.Click += this.EditPresets;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "zzzToolStripSeparator207";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "iconHistoryToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += this.ShowHistory;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "zzzToolStripSeparator208";
            this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsInternalToolStripMenuItem,
            this.toolsExternalToolStripMenuItem,
            this.toolStripSeparator12,
            this.toolsHistoryToolStripMenuItem,
            this.toolStripSeparator14,
            this.toolsOptionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            //
            // toolsInternalToolStripMenuItem
            //
            this.toolsInternalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsInternalTemplateEditorToolStripMenuItem,
            this.toolStripSeparator16,
            this.toolsInternalAutomatorToolStripMenuItem,
            this.toolsInternalAutomatorProToolStripMenuItem});
            this.toolsInternalToolStripMenuItem.Name = "toolsInternalToolStripMenuItem";
            this.toolsInternalToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.toolsInternalToolStripMenuItem.Text = "&Internal Tools";
            //
            // toolsInternalTemplateEditorToolStripMenuItem
            //
            this.toolsInternalTemplateEditorToolStripMenuItem.Name = "toolsInternalTemplateEditorToolStripMenuItem";
            this.toolsInternalTemplateEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsInternalTemplateEditorToolStripMenuItem.Text = "Template Editor";
            this.toolsInternalTemplateEditorToolStripMenuItem.Click += this.OpenTemplateEditor;
            // 
            // toolsInternalAutomatorToolStripMenuItem
            // 
            this.toolsInternalAutomatorToolStripMenuItem.Name = "toolsInternalAutomatorToolStripMenuItem";
            this.toolsInternalAutomatorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.toolsInternalAutomatorToolStripMenuItem.Text = "Automator";
            this.toolsInternalAutomatorToolStripMenuItem.Click += this.OpenAutomator;
            // 
            // toolsInternalAutomatorProToolStripMenuItem
            // 
            this.toolsInternalAutomatorProToolStripMenuItem.Name = "toolsInternalAutomatorProToolStripMenuItem";
            this.toolsInternalAutomatorProToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.toolsInternalAutomatorProToolStripMenuItem.Text = "Automator";
            this.toolsInternalAutomatorProToolStripMenuItem.Click += this.OpenAutomatorPro;
            // 
            // toolsExternalToolStripMenuItem
            // 
            this.toolsExternalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsExternalKeywordMixerToolStripMenuItem,
            this.toolsExternalKeywordMakerToolStripMenuItem,
            this.toolsExternalKeywordSelectorToolStripMenuItem,
            this.toolStripSeparator10,
            this.toolsExternalTextCleanerToolStripMenuItem,
            this.toolsExternalTextFilterToolStripMenuItem,
            this.toolStripSeparator11,
            this.toolsExternalDetailsIniToolStripMenuItem});
            this.toolsExternalToolStripMenuItem.Name = "toolsExternalToolStripMenuItem";
            this.toolsExternalToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.toolsExternalToolStripMenuItem.Text = "&External Tools";
            // 
            // toolsExternalKeywordMixerToolStripMenuItem
            // 
            this.toolsExternalKeywordMixerToolStripMenuItem.Name = "toolsExternalKeywordMixerToolStripMenuItem";
            this.toolsExternalKeywordMixerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalKeywordMixerToolStripMenuItem.Text = "Keyword &Mixer";
            this.toolsExternalKeywordMixerToolStripMenuItem.Click += this.OpenKeywordMixer;
            // 
            // toolsExternalKeywordMakerToolStripMenuItem
            // 
            this.toolsExternalKeywordMakerToolStripMenuItem.Name = "toolsExternalKeywordMakerToolStripMenuItem";
            this.toolsExternalKeywordMakerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalKeywordMakerToolStripMenuItem.Text = "Keyword M&aker";
            this.toolsExternalKeywordMakerToolStripMenuItem.Click += this.OpenKeywordMaker;
            // 
            // toolsExternalKeywordSelectorToolStripMenuItem
            // 
            this.toolsExternalKeywordSelectorToolStripMenuItem.Name = "toolsExternalKeywordSelectorToolStripMenuItem";
            this.toolsExternalKeywordSelectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalKeywordSelectorToolStripMenuItem.Text = "Keyword &Selector";
            this.toolsExternalKeywordSelectorToolStripMenuItem.Click += this.OpenKeywordSelector;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
            // 
            // toolsExternalTextCleanerToolStripMenuItem
            // 
            this.toolsExternalTextCleanerToolStripMenuItem.Name = "toolsExternalTextCleanerToolStripMenuItem";
            this.toolsExternalTextCleanerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalTextCleanerToolStripMenuItem.Text = "Text &Cleaner";
            this.toolsExternalTextCleanerToolStripMenuItem.Click += this.OpenTextCleaner;
            // 
            // toolsExternalTextFilterToolStripMenuItem
            // 
            this.toolsExternalTextFilterToolStripMenuItem.Name = "toolsExternalTextFilterToolStripMenuItem";
            this.toolsExternalTextFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalTextFilterToolStripMenuItem.Text = "Text &Filter";
            this.toolsExternalTextFilterToolStripMenuItem.Click += this.OpenTextFilter;
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(177, 6);
            // 
            // toolsExternalDetailsIniToolStripMenuItem
            // 
            this.toolsExternalDetailsIniToolStripMenuItem.Name = "toolsExternalDetailsIniToolStripMenuItem";
            this.toolsExternalDetailsIniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsExternalDetailsIniToolStripMenuItem.Text = "&Details.ini Generator";
            this.toolsExternalDetailsIniToolStripMenuItem.Click += this.OpenDetailsIniGenerator;
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "zzzToolStripSeparator212";
            this.toolStripSeparator12.Size = new System.Drawing.Size(156, 6);
            // 
            // toolsHistoryToolStripMenuItem
            // 
            this.toolsHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsHistoryWorkSpacesToolStripMenuItem,
            this.toolStripSeparator13,
            this.toolsHistoryKeywordsToolStripMenuItem,
            this.toolsHistoryTextToolStripMenuItem,
            this.toolsHistoryImagesToolStripMenuItem,
            this.toolsHistoryTemplatesToolStripMenuItem,
            this.toolsHistoryPresetsToolStripMenuItem});
            this.toolsHistoryToolStripMenuItem.Name = "toolsHistoryToolStripMenuItem";
            this.toolsHistoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.toolsHistoryToolStripMenuItem.Text = "&History";
            // 
            // toolsHistoryWorkSpacesToolStripMenuItem
            // 
            this.toolsHistoryWorkSpacesToolStripMenuItem.Name = "toolsHistoryWorkSpacesToolStripMenuItem";
            this.toolsHistoryWorkSpacesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryWorkSpacesToolStripMenuItem.Text = "WorkSpaces";
            this.toolsHistoryWorkSpacesToolStripMenuItem.Click += this.OpenWorkSpacesHistory;
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(135, 6);
            // 
            // toolsHistoryKeywordsToolStripMenuItem
            // 
            this.toolsHistoryKeywordsToolStripMenuItem.Name = "toolsHistoryKeywordsToolStripMenuItem";
            this.toolsHistoryKeywordsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryKeywordsToolStripMenuItem.Text = "Keywords";
            this.toolsHistoryKeywordsToolStripMenuItem.Click += this.OpenKeywordsHistory;
            // 
            // toolsHistoryTextToolStripMenuItem
            // 
            this.toolsHistoryTextToolStripMenuItem.Name = "toolsHistoryTextToolStripMenuItem";
            this.toolsHistoryTextToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryTextToolStripMenuItem.Text = "Text";
            this.toolsHistoryTextToolStripMenuItem.Click += this.OpenKeywordsHistory;
            // 
            // toolsHistoryImagesToolStripMenuItem
            // 
            this.toolsHistoryImagesToolStripMenuItem.Name = "toolsHistoryImagesToolStripMenuItem";
            this.toolsHistoryImagesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryImagesToolStripMenuItem.Text = "Images";
            this.toolsHistoryImagesToolStripMenuItem.Click += this.OpenImagesHistory;
            // 
            // toolsHistoryTemplatesToolStripMenuItem
            // 
            this.toolsHistoryTemplatesToolStripMenuItem.Name = "toolsHistoryTemplatesToolStripMenuItem";
            this.toolsHistoryTemplatesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryTemplatesToolStripMenuItem.Text = "Templates";
            this.toolsHistoryTemplatesToolStripMenuItem.Click += this.OpenTemplatesHistory;
            // 
            // toolsHistoryPresetsToolStripMenuItem
            // 
            this.toolsHistoryPresetsToolStripMenuItem.Name = "toolsHistoryPresetsToolStripMenuItem";
            this.toolsHistoryPresetsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toolsHistoryPresetsToolStripMenuItem.Text = "Presets";
            this.toolsHistoryTemplatesToolStripMenuItem.Click += this.OpenPresetsHistory;
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(156, 6);
            // 
            // toolsOptionsToolStripMenuItem
            // 
            this.toolsOptionsToolStripMenuItem.Name = "toolsOptionsToolStripMenuItem";
            this.toolsOptionsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.toolsOptionsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.toolsOptionsToolStripMenuItem.Text = "&Options";
            this.toolsOptionsToolStripMenuItem.Click += this.EditOptions;
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(149, 6);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += this.CloseWindow;
            this.mainContextMenuStrip.ResumeLayout(false);
        }

        protected System.Windows.Forms.NotifyIcon mainNotifyIcon;
        protected System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripMenuItem workSpaceToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem workSpaceNewToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripMenuItem workSpaceEditToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem tasksNewToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        protected System.Windows.Forms.ToolStripMenuItem tasksEditToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        protected System.Windows.Forms.ToolStripMenuItem tasksDeleteToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem tasksDeleteNewToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem tasksDeleteCompletedToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem tasksDeleteFailedToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        protected System.Windows.Forms.ToolStripMenuItem tasksDeleteAllToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        protected System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem dataKeywordsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem dataTextToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem dataImagesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem dataTemplatesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem dataPresetsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        protected System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        protected System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsInternalToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsInternalTemplateEditorToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsInternalAutomatorToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsInternalAutomatorProToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalKeywordMixerToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalKeywordMakerToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalKeywordSelectorToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalTextCleanerToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalTextFilterToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        protected System.Windows.Forms.ToolStripMenuItem toolsExternalDetailsIniToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryWorkSpacesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryKeywordsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryTextToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryImagesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryTemplatesToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolsHistoryPresetsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        protected System.Windows.Forms.ToolStripMenuItem toolsOptionsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        protected System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        protected System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        #endregion
    }
}
