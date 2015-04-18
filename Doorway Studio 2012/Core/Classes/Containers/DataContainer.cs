using Core.Classes.Containers.Items;
using Core.Enums;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using IO = System.IO;

namespace Core.Classes.Containers
{
    public class DataContainer : IDataContainer
    {
        public DataContainer()
        {
            this.Items = new EventedList<IWorkSpace>();

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

        public IWorkSpace this[int Index] { get { return this.Items[Index]; } }

        public int Count { get { return this.Items.Count; } }

        public IEventedList<IWorkSpace> Items { get; set; }

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
                this.Items.Add(new WorkSpace(directories[i]));
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
                (this.Items[i] as WorkSpace).Save(string.IsNullOrEmpty(this.Items[i].Path)
                                                           ? IO.Path.Combine(DataPath, this.Items[i].ID.ToLongString())
                                                           : this.Items[i].Path);
            }

            Logger.Instanse.Append("Core: Saved.", LogMessageType.Info);
        }

        protected void ItemAdded(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Added.", (Sender as IItem).Name), LogMessageType.Info);
        }

        protected void ItemRemoved(object Sender)
        {
            Logger.Instanse.Append(string.Format("WorkSpace: {0}. Removed.", (Sender as IItem).Name), LogMessageType.Info);
        }

        public IWorkSpace Select(int Value, ItemSelectType Type)
        {
            switch (Type)
            {
                case ItemSelectType.Index:
                    {
                        return this.Items[Value];
                    }

                case ItemSelectType.ID:
                    {
                        int index = -1;
                        for (int i = 0; i < this.Items.Count; i++)
                        {
                            if (this.Items[i].ID == Value)
                            {
                                index = i;
                                break;
                            }
                        }

                        return index == -1 ? null : this.Items[index];
                    }
            }

            return this.Items[Value];
        }
    }
}
