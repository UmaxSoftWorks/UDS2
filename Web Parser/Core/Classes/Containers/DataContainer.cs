using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers;
using IO = System.IO;

namespace WebParser.Core.Classes.Containers
{
    public class DataContainer
    {
        public DataContainer()
        {
            this.Items = new EventedList<Task>();

            // Events
            this.Items.ItemAdded += this.ItemAdded;
            this.Items.ItemRemoved += this.ItemRemoved;
        }

        #region IDisposable

        public void Dispose()
        {
            // Events
            this.Items.ItemAdded -= this.ItemAdded;
            this.Items.ItemRemoved -= this.ItemRemoved;

            // Data
            this.Items = null;
        }

        #endregion

        #region IDataContainer

        public Task this[int Index] { get { return this.Items[Index]; } }

        public int Count { get { return this.Items.Count; } }

        public IEventedList<Task> Items { get; set; }

        #endregion

        /// <summary>
        /// Loads data from specified directory
        /// </summary>
        /// <param name="DataPath">Path to the directory</param>
        public void Load(string DataPath)
        {
            if (!IO.Directory.Exists(DataPath))
            {
                return;
            }

            Logger.Instanse.Append("Core: Loading...", LogMessageType.Info);

            // Clear read only from Data directory
            IO.DirectoryInfo dataDirectory = new IO.DirectoryInfo(DataPath);
            dataDirectory.Attributes = IO.FileAttributes.Normal;

            string[] directories = IO.Directory.GetDirectories(DataPath, "*", IO.SearchOption.TopDirectoryOnly);

            for (int i = 0; i < directories.Length; i++)
            {
                this.Items.Add(new Task(directories[i]));
            }

            Logger.Instanse.Append("Core: Loaded.", LogMessageType.Info);
        }

        /// <summary>
        /// Saves data to the directory
        /// </summary>
        /// <param name="DataPath">Path to the directory</param>
        public void Save(string DataPath)
        {
            Logger.Instanse.Append("Core: Saving...", LogMessageType.Info);
            for (int i = 0; i < this.Items.Count; i++)
            {
                this.Items[i].Save(string.IsNullOrEmpty(this.Items[i].Path)
                                       ? IO.Path.Combine(DataPath, this.Items[i].ID.ToLongString())
                                       : this.Items[i].Path);
            }

            Logger.Instanse.Append("Core: Saved.", LogMessageType.Info);
        }

        protected void ItemAdded(object Sender)
        {
            Logger.Instanse.Append(string.Format("Task: {0}. Added.", (Sender as Task).Name), LogMessageType.Info);
        }

        protected void ItemRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("Task: {0}. Removed.", (Sender as Task).Name), LogMessageType.Info);
        }
    }
}
