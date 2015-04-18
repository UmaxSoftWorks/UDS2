using System;
using Core.Enums;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Classes.Ini;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using IO = System.IO;

namespace Core.Classes.Containers.Items
{
    public class WorkSpace : IWorkSpace
    {
        /// <summary>
        /// Initializes a new instance of the WorkSpace class.
        /// </summary>
        public WorkSpace()
        {
            this.Name = string.Empty;

            // General
            this.Tasks = new EventedList<ITask>();
            this.Images = new EventedList<IImage>();
            this.Keywords = new EventedList<IKeyWord>();
            this.Text = new EventedList<IText>();
            this.Presets = new EventedList<IPreset>();
            this.Templates = new EventedList<ITemplate>();

            // Events
            this.InitializeEvents();
        }

        /// <summary>
        /// Initializes a new instance of the WorkSpace class.
        /// </summary>
        /// <param name="WorkSpacePath">Path to the directory, from which WorkSpace should be loaded.</param>
        public WorkSpace(string WorkSpacePath)
            : this()
        {
            this.Path = WorkSpacePath;
            this.Load(WorkSpacePath);
        }

        public event SimpleEventHandler Changed;

        #region Information
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; protected set; }
        #endregion

        #region MainData
        public IEventedList<ITask> Tasks { get; set; }
        public IEventedList<IImage> Images { get; set; }
        public IEventedList<IKeyWord> Keywords { get; set; }
        public IEventedList<IText> Text { get; set; }
        public IEventedList<IPreset> Presets { get; set; }
        public IEventedList<ITemplate> Templates { get; set; }

        //private ItemStatistics statistics;
        #endregion

        #region IDisposable
        public void Dispose()
        {
            this.Images = null;
            this.Keywords = null;
            this.Presets = null;
            this.Tasks = null;
            this.Templates = null;
            this.Text = null;
        }
        #endregion

        /// <summary>
        /// Saves WorkSpace to the specified directory
        /// </summary>
        /// <param name="WorkSpacePath">Path to the directory where WorkSpace will be saved.</param>
        public void Save(string WorkSpacePath)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Saving...", this.Name), LogMessageType.Info);
            try
            {
                if (!IOHelper.CheckDirectoryExists(WorkSpacePath))
                {
                    IOHelper.CreateDirectory(WorkSpacePath);
                }

                // Saving ini
                IniWorker ini = new IniWorker(IO.Path.Combine(WorkSpacePath, "details.ini"));
                ini.IniWriteValue("General", "ID", this.ID.ToString());
                ini.IniWriteValue("General", "Name", this.Name);

                this.SaveTasks(IO.Path.Combine(WorkSpacePath, "Tasks"));
                this.SaveImages(IO.Path.Combine(WorkSpacePath, "Images"));
                this.SaveKeywords(IO.Path.Combine(WorkSpacePath, "Keywords"));
                this.SaveTexts(IO.Path.Combine(WorkSpacePath, "Text"));
                this.SavePresets(IO.Path.Combine(WorkSpacePath, "Presets"));
                this.SaveTemplates(IO.Path.Combine(WorkSpacePath, "Templates"));

                Logger.Instanse.Append(string.Format("WorkSpace: {0}. Saved.", this.Name), LogMessageType.Info);
            }
            catch (Exception ex)
            {
                Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save.", this.Name), LogMessageType.Info);
                if (Options.Instanse.LogDebugMode)
                {
                    Logger.Instanse.Append(ex);
                }
            }
        }

        public WorkSpace Copy(string WorkSpaceName)
        {
            string itemPath = IO.Path.Combine(this.Path, IO.Path.Combine("Data", Core.Instanse.Data.Items.NextID().ToLongString()));

            this.Save(itemPath);

            return new WorkSpace(itemPath)
            {
                Name = WorkSpaceName,
                ID = Core.Instanse.Data.Items.NextID()
            };
        }

        /// <summary>
        /// Delete WorkSpace
        /// </summary>
        public void Delete()
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Deleting...", this.Name), LogMessageType.Info);
            try
            {
                this.DeleteImages();
                this.DeleteKeywords();
                this.DeleteTemplates();
                this.DeleteTexts();
                this.DeletePresets();
                this.DeleteTasks();

                IO.Directory.Delete(this.Path, true);
                Logger.Instanse.Append(string.Format("WorkSpace: {0}. Deleted.", this.Name), LogMessageType.Info);
            }
            catch (Exception ex)
            {
                Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete.", this.Name), LogMessageType.Info);
                if (Options.Instanse.LogDebugMode)
                {
                    Logger.Instanse.Append(ex);
                }
            }

            // Events
            this.Tasks.CountChanged -= this.Changed;
            this.Images.CountChanged -= this.Changed;
            this.Keywords.CountChanged -= this.Changed;
            this.Text.CountChanged -= this.Changed;
            this.Presets.CountChanged -= this.Changed;
            this.Templates.CountChanged -= this.Changed;

            this.Tasks.ItemAdded -= this.TasksAdded;
            this.Images.ItemAdded -= this.ImagesAdded;
            this.Keywords.ItemAdded -= this.KeywordsAdded;
            this.Text.ItemAdded -= this.TextAdded;
            this.Presets.ItemAdded -= this.PresetsAdded;
            this.Templates.ItemAdded -= this.TemplatesAdded;

            this.Tasks.ItemRemoved -= this.TasksRemoved;
            this.Images.ItemRemoved -= this.ImagesRemoved;
            this.Keywords.ItemRemoved -= this.KeywordsRemoved;
            this.Text.ItemRemoved -= this.TextRemoved;
            this.Presets.ItemRemoved -= this.PresetsRemoved;
            this.Templates.ItemRemoved -= this.TemplatesRemoved;

            // Deleting
            if (IOHelper.CheckDirectoryExists(this.Path))
            {
                try
                {
                    IO.Directory.Delete(this.Path, true);
                }
                catch (Exception) { }
            }
        }

        protected void SaveTasks(string TasksPath)
        {
            for (int i = 0; i < this.Tasks.Count; i++)
            {
                try
                {
                    (this.Tasks[i] as Task).Save(IO.Path.Combine(TasksPath, this.Tasks[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Task (Name: {1}, ID: {2}) saved.", this.Name, this.Tasks[i].Name, this.Tasks[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Task (Name: {1}, ID: {2}).", this.Name, this.Tasks[i].Name, this.Tasks[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void SaveImages(string ImagesPath)
        {
            for (int i = 0; i < this.Images.Count; i++)
            {
                try
                {
                    (this.Images[i] as Image).Save(IO.Path.Combine(ImagesPath, this.Images[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Images (Name: {1}, ID: {2}) saved.", this.Name, this.Images[i].Name, this.Images[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Images (Name: {1}, ID: {2}).", this.Name, this.Images[i].Name, this.Images[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void SaveKeywords(string KeywordsPath)
        {
            for (int i = 0; i < this.Keywords.Count; i++)
            {
                try
                {
                    (this.Keywords[i] as KeyWord).Save(IO.Path.Combine(KeywordsPath, this.Keywords[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Keywords (Name: {1}, ID: {2}) saved.", this.Name, this.Keywords[i].Name, this.Keywords[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Keywords (Name: {1}, ID: {2}).", this.Name, this.Keywords[i].Name, this.Keywords[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void SaveTexts(string TextsPath)
        {
            for (int i = 0; i < this.Text.Count; i++)
            {
                try
                {
                    (this.Text[i] as Text).Save(IO.Path.Combine(TextsPath, this.Text[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Text (Name: {1}, ID: {2}) saved.", this.Name, this.Text[i].Name, this.Text[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Text (Name: {1}, ID: {2}).", this.Name, this.Text[i].Name, this.Text[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void SavePresets(string PresetsPath)
        {
            for (int i = 0; i < this.Presets.Count; i++)
            {
                try
                {
                    (this.Presets[i] as Preset).Save(IO.Path.Combine(PresetsPath, this.Presets[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Preset (Name: {1}, ID: {2}) saved.", this.Name, this.Presets[i].Name, this.Presets[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Preset (Name: {1}, ID: {2}).", this.Name, this.Presets[i].Name, this.Presets[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void SaveTemplates(string TemplatesPath)
        {
            for (int i = 0; i < this.Templates.Count; i++)
            {
                try
                {
                    (this.Templates[i] as Template).Save(IO.Path.Combine(TemplatesPath, this.Templates[i].ID.ToLongString()));
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Template (Name: {1}, ID: {2}) saved.", this.Name, this.Templates[i].Name, this.Templates[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to save Template (Name: {1}, ID: {2}).", this.Name, this.Templates[i].Name, this.Templates[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeleteImages()
        {
            for (int i = 0; i < this.Images.Count; i++)
            {
                try
                {
                    (this.Images[i] as Image).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Images (Name: {1}, ID: {2}) deleted.", this.Name, this.Images[i].Name, this.Images[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Images (Name: {1}, ID: {2}).", this.Name, this.Images[i].Name, this.Images[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeleteKeywords()
        {
            for (int i = 0; i < this.Keywords.Count; i++)
            {
                try
                {
                    (this.Keywords[i] as KeyWord).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Keywords (Name: {1}, ID: {2}) deleted.", this.Name, this.Keywords[i].Name, this.Keywords[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Keywords (Name: {1}, ID: {2}).", this.Name, this.Keywords[i].Name, this.Keywords[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeleteTemplates()
        {
            for (int i = 0; i < this.Templates.Count; i++)
            {
                try
                {
                    (this.Templates[i] as Template).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Template (Name: {1}, ID: {2}) deleted.", this.Name, this.Templates[i].Name, this.Templates[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Template (Name: {1}, ID: {2}).", this.Name, this.Templates[i].Name, this.Templates[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeleteTexts()
        {
            for (int i = 0; i < this.Text.Count; i++)
            {
                try
                {
                    (this.Text[i] as Text).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Text (Name: {1}, ID: {2}) deleted.", this.Name, this.Text[i].Name, this.Text[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Text (Name: {1}, ID: {2}).", this.Name, this.Text[i].Name, this.Text[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeletePresets()
        {
            for (int i = 0; i < this.Presets.Count; i++)
            {
                try
                {
                    (this.Presets[i] as Preset).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Preset (Name: {1}, ID: {2}) deleted.", this.Name, this.Presets[i].Name, this.Presets[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Preset (Name: {1}, ID: {2}).", this.Name, this.Presets[i].Name, this.Presets[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void DeleteTasks()
        {
            for (int i = 0; i < this.Tasks.Count; i++)
            {
                try
                {
                    (this.Tasks[i] as Task).Delete();
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Task (Name: {1}, ID: {2}) deleted.", this.Name, this.Tasks[i].Name, this.Tasks[i].ID.ToString()), LogMessageType.Info);
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to delete Task (Name: {1}, ID: {2}).", this.Name, this.Tasks[i].Name, this.Tasks[i].ID.ToString()), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        protected void Load(string WorkSpacePath)
        {
            try
            {
                // Load ini
                IniWorker ini = new IniWorker(IO.Path.Combine(WorkSpacePath, "details.ini"));
                this.ID = int.Parse(ini.IniReadValue("General", "ID"));
                this.Name = ini.IniReadValue("General", "Name");
                Logger.Instanse.Append(string.Format("WorkSpace: {0}. Loading...", this.Name), LogMessageType.Info);
            }
            catch (Exception ex)
            {
                Logger.Instanse.Append(string.Format("WorkSpace: Failed to load {0}.", WorkSpacePath), LogMessageType.Info);
                if (Options.Instanse.LogDebugMode)
                {
                    Logger.Instanse.Append(ex);
                }

                return;
            }

            this.LoadKeywords(IO.Path.Combine(WorkSpacePath, "Keywords"));
            this.LoadImages(IO.Path.Combine(WorkSpacePath, "Images"));
            this.LoadTexts(IO.Path.Combine(WorkSpacePath, "Text"));
            this.LoadPresets(IO.Path.Combine(WorkSpacePath, "Presets"));
            this.LoadTemplates(IO.Path.Combine(WorkSpacePath, "Templates"));
            this.LoadTasks(IO.Path.Combine(WorkSpacePath, "Tasks"));
        }

        protected void LoadTasks(string TasksPath)
        {
            if (IOHelper.CheckDirectoryExists(TasksPath))
            {
                string[] directories = IO.Directory.GetDirectories(TasksPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Tasks.Add(new Task(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Task loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Task {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void LoadKeywords(string KeywordsPath)
        {
            if (IOHelper.CheckDirectoryExists(KeywordsPath))
            {
                string[] directories = IO.Directory.GetDirectories(KeywordsPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Keywords.Add(new KeyWord(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Keywords loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Keywords {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void LoadImages(string ImagesPath)
        {
            if (IOHelper.CheckDirectoryExists(ImagesPath))
            {
                string[] directories = IO.Directory.GetDirectories(ImagesPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Images.Add(new Image(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Images loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Images {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void LoadTexts(string TextsPath)
        {
            if (IOHelper.CheckDirectoryExists(TextsPath))
            {
                string[] directories = IO.Directory.GetDirectories(TextsPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Text.Add(new Text(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Text loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Text {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void LoadPresets(string PresetsPath)
        {
            if (IOHelper.CheckDirectoryExists(PresetsPath))
            {
                string[] directories = IO.Directory.GetDirectories(PresetsPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Presets.Add(new Preset(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Preset loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Preset {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void LoadTemplates(string TemplatesPath)
        {
            if (IOHelper.CheckDirectoryExists(TemplatesPath))
            {
                string[] directories = IO.Directory.GetDirectories(TemplatesPath, "*", IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < directories.Length; i++)
                {
                    try
                    {
                        this.Templates.Add(new Template(directories[i]));
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Template loaded {1}.", this.Name, directories[i]), LogMessageType.Info);
                    }
                    catch (Exception ex)
                    {
                        Logger.Instanse.Append(string.Format("WorkSpace: {0}. Failed to load Template {1}.", this.Name, directories[i]), LogMessageType.Info);
                        if (Options.Instanse.LogDebugMode)
                        {
                            Logger.Instanse.Append(ex);
                        }
                    }
                }
            }
        }

        protected void InitializeEvents()
        {
            this.Tasks.CountChanged += this.Changed;
            this.Images.CountChanged += this.Changed;
            this.Keywords.CountChanged += this.Changed;
            this.Text.CountChanged += this.Changed;
            this.Presets.CountChanged += this.Changed;
            this.Templates.CountChanged += this.Changed;

            this.Tasks.ItemAdded += this.TasksAdded;
            this.Images.ItemAdded += this.ImagesAdded;
            this.Keywords.ItemAdded += this.KeywordsAdded;
            this.Text.ItemAdded += this.TextAdded;
            this.Presets.ItemAdded += this.PresetsAdded;
            this.Templates.ItemAdded += this.TemplatesAdded;

            this.Tasks.ItemRemoved += this.TasksRemoved;
            this.Images.ItemRemoved += this.ImagesRemoved;
            this.Keywords.ItemRemoved += this.KeywordsRemoved;
            this.Text.ItemRemoved += this.TextRemoved;
            this.Presets.ItemRemoved += this.PresetsRemoved;
            this.Templates.ItemRemoved += this.TemplatesRemoved;
        }

        protected void ImagesAdded(object Sender)
        {
            if (Sender is Image)
            {
                if (this.Images.Number((Sender as Image).ID) != 1)
                {
                    (Sender as Image).ID = this.Images.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Images {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void KeywordsAdded(object Sender)
        {
            if (Sender is KeyWord)
            {
                if (this.Keywords.Number((Sender as KeyWord).ID) != 1)
                {
                    (Sender as KeyWord).ID = this.Keywords.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Keywords {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void PresetsAdded(object Sender)
        {
            if (Sender is Preset)
            {
                if (this.Presets.Number((Sender as Preset).ID) != 1)
                {
                    (Sender as Preset).ID = this.Presets.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Preset {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TasksAdded(object Sender)
        {
            if (Sender is Task)
            {
                if (this.Tasks.Number((Sender as Task).ID) != 1)
                {
                    (Sender as Task).ID = this.Tasks.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Task {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TemplatesAdded(object Sender)
        {
            if (Sender is Template)
            {
                if (this.Templates.Number((Sender as Template).ID) != 1)
                {
                    (Sender as Template).ID = this.Templates.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Template {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TextAdded(object Sender)
        {
            if (Sender is Text)
            {
                if (this.Text.Number((Sender as Text).ID) != 1)
                {
                    (Sender as Text).ID = this.Text.NextID();
                }
            }

            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Text {1} added.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void ImagesRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Images {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void KeywordsRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Keywords {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void PresetsRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Preset {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TasksRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Task {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TemplatesRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Template {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void TextRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Text {1} removed.", this.Name, (Sender as IItem).Name), LogMessageType.Info);
        }


        public ITask SelectTask(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Tasks[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Tasks.Count; i++)
                        {
                            if (this.Tasks[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Tasks[index];
                    }
            }

            return this.Tasks[Value];
        }

        public IImage SelectImage(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Images[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Images.Count; i++)
                        {
                            if (this.Images[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Images[index];
                    }
            }

            return this.Images[Value];
        }

        public IKeyWord SelectKeyword(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Keywords[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Keywords.Count; i++)
                        {
                            if (this.Keywords[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Keywords[index];
                    }
            }

            return this.Keywords[Value];
        }

        public IText SelectText(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Text[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Text.Count; i++)
                        {
                            if (this.Text[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Text[index];
                    }
            }

            return this.Text[Value];
        }

        public IPreset SelectPreset(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Presets[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Presets.Count; i++)
                        {
                            if (this.Presets[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Presets[index];
                    }
            }

            return this.Presets[Value];
        }

        public ITemplate SelectTemplate(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Templates[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Templates.Count; i++)
                        {
                            if (this.Templates[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Templates[index];
                    }
            }

            return this.Templates[Value];
        }
    }
}
