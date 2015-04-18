using System;
using System.ComponentModel;
using System.Windows.Forms;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Windows.Classes;
using Umax.Windows.Enums;
using Umax.Windows.Helpers;
using Umax.Windows.Interfaces;

namespace Umax.Windows.Controls
{
    public partial class MenuStrip : System.Windows.Forms.MenuStrip, IEventedControl
    {
        public MenuStrip()
        {
            InitializeComponent();

            this.Initialize();
        }

        private MainMenuType menuType;
        public MainMenuType MenuType
        {
            get { return this.menuType; }
            set
            {
                this.menuType = value;

                switch (this.MenuType)
                {
                    case MainMenuType.None:
                        {
                            this.toolsViewPinToolStripMenuItem.Visible = false;
                            this.toolsViewPinToolStripMenuItem.Enabled = false;
                            this.toolsViewLocationToolStripMenuItem.Visible = false;
                            this.toolsViewLocationToolStripMenuItem.Enabled = false;
                            break;
                        }

                    case MainMenuType.Manager:
                        {
                            this.toolsViewNewsToolStripMenuItem.Visible = false;
                            this.toolsViewNewsToolStripMenuItem.Enabled = false;
                            this.toolsViewGeneralToolStripMenuItem.Visible = false;
                            this.toolsViewGeneralToolStripMenuItem.Enabled = false;
                            this.toolsViewLargeCalendarToolStripMenuItem.Visible = false;
                            this.toolsViewLargeCalendarToolStripMenuItem.Enabled = false;
                            break;
                        }
                }
            }
        }

        public MenuStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Initialize();
        }

        /// <summary>
        /// Gets or sets a value indicating whether menu is Initialized.
        /// </summary>
        protected bool Initialized { get; set; }

        protected virtual void Initialize()
        {
            if (this.Initialized || this.DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
            this.InitializeEvents();

            this.ApplySettings();
        }

        /// <summary>
        /// The initialize images.
        /// </summary>
        protected virtual void InitializeImages()
        {
            // File
            fileToolStripMenuItem.Image = Resources.Resources.Save;

            fileWorkSpaceToolStripMenuItem.Image = Resources.Resources.WorkSpace;
            fileWorkSpaceNewToolStripMenuItem.Image = Resources.Resources.PlusGreen;
            fileWorkSpaceEditToolStripMenuItem.Image = Resources.Resources.Edit;

            fileTasksToolStripMenuItem.Image = Resources.Resources.Task;
            fileTasksNewToolStripMenuItem.Image = Resources.Resources.PlusBlue;
            fileTasksEditToolStripMenuItem.Image = Resources.Resources.Edit;
            fileTasksDeleteToolStripMenuItem.Image = Resources.Resources.Delete;
            fileTasksDeleteNewToolStripMenuItem.Image = Resources.Resources.ImageGreen;
            fileTasksDeleteCompletedToolStripMenuItem.Image = Resources.Resources.Ok;
            fileTasksDeleteFailedToolStripMenuItem.Image = Resources.Resources.Delete;

            fileDataToolStripMenuItem.Image = Resources.Resources.Folder;
            fileDataKeywordsToolStripMenuItem.Image = Resources.Resources.Item;
            fileDataTextToolStripMenuItem.Image = Resources.Resources.Item;
            fileDataImagesToolStripMenuItem.Image = Resources.Resources.Image;
            fileDataTemplatesToolStripMenuItem.Image = Resources.Resources.Folder;
            fileDataPresetsToolStripMenuItem.Image = Resources.Resources.Preset;

            fileHistoryToolStripMenuItem.Image = Resources.Resources.History;

            fileExitToolStripMenuItem.Image = Resources.Resources.Delete;

            // Tools
            toolsToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsInternalToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsInternalTemplateEditorToolStripMenuItem.Image = Resources.Resources.Folder;
            toolsInternalAutomatorToolStripMenuItem.Image = Resources.Resources.Automator;
            toolsInternalAutomatorProToolStripMenuItem.Image = Resources.Resources.AutomatorPro;
            toolsExternalToolStripMenuItem.Image = Resources.Resources.Tools;
            toolsHistoryToolStripMenuItem.Image = Resources.Resources.History;
            toolsHistoryWorkSpacesToolStripMenuItem.Image = Resources.Resources.WorkSpace;
            toolsHistoryKeywordsToolStripMenuItem.Image = Resources.Resources.Item;
            toolsHistoryTextToolStripMenuItem.Image = Resources.Resources.Item;
            toolsHistoryImagesToolStripMenuItem.Image = Resources.Resources.Image;
            toolsHistoryTemplatesToolStripMenuItem.Image = Resources.Resources.Folder;
            toolsHistoryPresetsToolStripMenuItem.Image = Resources.Resources.Preset;
            toolsViewToolStripMenuItem.Image = Resources.Resources.View;
            toolsOptionsToolStripMenuItem.Image = Resources.Resources.Settings;

            // Help
            helpToolStripMenuItem.Image = Resources.Resources.Help;
            helpHelpToolStripMenuItem.Image = Resources.Resources.Help;
            helpAboutToolStripMenuItem.Image = Resources.Resources.Info;

            // Windows
            windowsToolStripMenuItem.Image = Resources.Resources.Windows;
        }

        protected void CreateWorkSpace(object sender, EventArgs e)
        {
            DataHelper.CreateWorkSpace();
        }

        protected void EditTasks(object sender, EventArgs e)
        {
            DataHelper.EditTasks();
        }

        protected void DeleteNewTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.New);
        }

        protected void DeleteCompletedTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.Done);
        }

        protected void DeleteFailedTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks(TaskStateType.Error);
        }

        protected void DeleteAllTasks(object sender, EventArgs e)
        {
            Core.Helpers.Helper.DeleteTasks();
        }

        protected void CreateTask(object sender, EventArgs e)
        {
            DataHelper.CreateTask();
        }

        protected void ShowHistory(object sender, EventArgs e)
        {
            DataHelper.ShowLog();
        }

        protected void EditKeywords(object sender, EventArgs e)
        {
            DataHelper.EditKeywords();
        }

        protected void EditText(object sender, EventArgs e)
        {
            DataHelper.EditText();
        }

        protected void EditImages(object sender, EventArgs e)
        {
            DataHelper.EditImages();
        }

        protected void EditTemplates(object sender, EventArgs e)
        {
            DataHelper.EditTemplates();
        }

        protected void EditPresets(object sender, EventArgs e)
        {
            DataHelper.EditPresets();
        }

        protected void EditWorkSpaces(object sender, EventArgs e)
        {
            DataHelper.EditWorkSpaces();
        }

        protected void CloseWindow(object sender, EventArgs e)
        {
            Helper.Close();
        }

        protected void OpenTemplateEditor(object sender, EventArgs e)
        {
            ToolsHelper.OpenTemplateEditor();
        }

        protected void OpenAutomator(object sender, EventArgs e)
        {
            ToolsHelper.OpenAutomator();
        }

        protected void OpenAutomatorPro(object sender, EventArgs e)
        {
            ToolsHelper.OpenAutomatorPro();
        }

        protected void OpenKeywordMixer(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordMaker(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordSelector(object sender, EventArgs e)
        {
        }

        protected void OpenTextCleaner(object sender, EventArgs e)
        {
        }

        protected void OpenTextFilter(object sender, EventArgs e)
        {
        }

        protected void OpenDetailsIniGenerator(object sender, EventArgs e)
        {
        }

        protected void OpenWorkSpacesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenKeywordsHistory(object sender, EventArgs e)
        {
        }

        protected void OpenTextHistory(object sender, EventArgs e)
        {
        }

        protected void OpenImagesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenTemplatesHistory(object sender, EventArgs e)
        {
        }

        protected void OpenPresetsHistory(object sender, EventArgs e)
        {
        }

        protected void ShowEULA(object sender, EventArgs e)
        {
            Helper.ShowEULA();
        }

        protected void ShowAboutBox(object sender, EventArgs e)
        {
            Helper.ShowAboutBox();
        }

        protected void ViewNews(object sender, EventArgs e)
        {
            GuiOptions.Instanse.AppearanceNews = toolsViewNewsToolStripMenuItem.Checked;
        }

        protected void ViewGeneral(object sender, EventArgs e)
        {
            GuiOptions.Instanse.AppearanceGeneral = toolsViewGeneralToolStripMenuItem.Checked;
        }

        protected void ViewLargeCalendar(object sender, EventArgs e)
        {
            GuiOptions.Instanse.AppearanceLargeCalendar = toolsViewLargeCalendarToolStripMenuItem.Checked;
        }

        protected void EditOptions(object sender, EventArgs e)
        {
            DataHelper.EditOptions();
        }

        public void InitializeEvents()
        {
            GuiOptions.Instanse.NewsChanged += this.ShowNewsChanged;
            GuiOptions.Instanse.AppearanceGeneralChanged += this.ShowGeneralChanged;
            GuiOptions.Instanse.AppearanceLargeCalendarChanged += this.ShowLargeCalendarChanged;

            GuiOptions.Instanse.ManagerPinChanged += this.ManagerPinChanged;
            GuiOptions.Instanse.ManagerLocationChanged += this.ManagerLocationChanged;

            RunTime.Instance.Windows.CountChanged += this.WindowsCountChanged;
        }

        private void WindowsCountChanged()
        {
            this.RebuildWindowsMenu();
        }

        private void RebuildWindowsMenu()
        {
            // Unsubscribe events
            for (int i = 0; i < this.windowsToolStripMenuItem.DropDownItems.Count; i++)
            {
                this.windowsToolStripMenuItem.DropDownItems[i].Click -= this.WindowsClick;
            }

            // Rebuild menu
            this.windowsToolStripMenuItem.DropDownItems.Clear();
            for (int i = 0; i < RunTime.Instance.Windows.Count; i++)
            {
                    ToolStripMenuItem item = new ToolStripMenuItem();

                    item.Text = RunTime.Instance.Windows[i].Title;
                    item.Click += this.WindowsClick;

                    this.windowsToolStripMenuItem.DropDownItems.Add(item);
            }
            
            this.MenuChanged();
        }

        private void WindowsClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                RunTime.Instance.Windows[(sender as ToolStripMenuItem).Owner.Items.IndexOf(sender as ToolStripMenuItem)].Restore();
            }
        }

        public void DeInitializeEvents()
        {
            GuiOptions.Instanse.NewsChanged -= this.ShowNewsChanged;
            GuiOptions.Instanse.AppearanceGeneralChanged -= this.ShowGeneralChanged;
            GuiOptions.Instanse.AppearanceLargeCalendarChanged -= this.ShowLargeCalendarChanged;

            GuiOptions.Instanse.ManagerPinChanged -= this.ManagerPinChanged;
            GuiOptions.Instanse.ManagerLocationChanged -= this.ManagerLocationChanged;

            RunTime.Instance.Windows.CountChanged -= this.WindowsCountChanged;
        }

        public void UpdateControl()
        {

        }

        protected void ShowNewsChanged()
        {
            this.toolsViewNewsToolStripMenuItem.Checked = GuiOptions.Instanse.AppearanceNews;
            this.MenuChanged();
        }

        protected void ShowGeneralChanged()
        {
            this.toolsViewGeneralToolStripMenuItem.Checked = GuiOptions.Instanse.AppearanceGeneral;
            this.MenuChanged();
        }


        protected void ShowLargeCalendarChanged()
        {
            this.toolsViewLargeCalendarToolStripMenuItem.Checked = GuiOptions.Instanse.AppearanceLargeCalendar;
            this.MenuChanged();
        }

        protected void ViewPin(object sender, EventArgs e)
        {
            GuiOptions.Instanse.ManagerPin = !GuiOptions.Instanse.ManagerPin;
            this.MenuChanged();
        }

        protected void ViewLocationLeft(object sender, EventArgs e)
        {
            GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Left;
            this.MenuChanged();
        }

        protected void ViewLocationRight(object sender, EventArgs e)
        {
            GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Right;
            this.MenuChanged();
        }

        protected void ViewLocationCustom(object sender, EventArgs e)
        {
            GuiOptions.Instanse.ManagerLocation = ManagerLocationType.Custom;
            this.MenuChanged();
        }

        protected void ManagerPinChanged()
        {
            toolsViewPinToolStripMenuItem.Checked = GuiOptions.Instanse.ManagerPin;
            this.MenuChanged();
        }

        protected void ManagerLocationChanged()
        {
            switch (GuiOptions.Instanse.ManagerLocation)
            {
                case ManagerLocationType.Custom:
                    {
                        toolsViewLocationLeftToolStripMenuItem.Checked = false;
                        toolsViewLocationRightToolStripMenuItem.Checked = false;
                        toolsViewLocationCustomToolStripMenuItem.Checked = true;
                        break;
                    }

                case ManagerLocationType.Left:
                    {
                        toolsViewLocationCustomToolStripMenuItem.Checked = false;
                        toolsViewLocationRightToolStripMenuItem.Checked = false;
                        toolsViewLocationLeftToolStripMenuItem.Checked = true;
                        break;
                    }

                case ManagerLocationType.Right:
                    {
                        toolsViewLocationCustomToolStripMenuItem.Checked = false;
                        toolsViewLocationLeftToolStripMenuItem.Checked = false;
                        toolsViewLocationRightToolStripMenuItem.Checked = true;
                        break;
                    }
            }

            this.MenuChanged();
        }

        protected virtual void ApplySettings()
        {
            this.RenderMode = ToolStripRenderMode.Professional;

            this.ShowNewsChanged();
            this.ShowGeneralChanged();
            this.ShowLargeCalendarChanged();

            this.ManagerPinChanged();
            this.ManagerLocationChanged();
        }

        protected void MenuChanged()
        {
            if (this.Changed != null)
            {
                this.Changed();
            }
        }

        public event SimpleEventHandler Changed;
    }
}