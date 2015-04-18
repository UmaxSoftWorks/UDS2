using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.Classes.Containers.Items;
using Umax.Interfaces.Enums;
using Image = Core.Classes.Containers.Items.Image;
using IO = System.IO;

namespace Umax.Windows.Controls.Editors
{
    public partial class ImagesEditorControl : UserControl
    {
        public ImagesEditorControl()
        {
            InitializeComponent();

            this.SelectedWorkSpace = -1;
            this.SelectedImages = -1;
        }

        public int SelectedWorkSpace { get; set; }
        public int SelectedImages { get; set; }

        protected bool CanExecuteAction
        {
            get { return (this.SelectedWorkSpace != -1) && (this.SelectedImages != -1); }
        }

        private List<string> images;

        private void ImagesEditorControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.Initialized = true;

            this.InitializeImages();
        }

        private void InitializeImages()
        {
            addToolStripSplitButton.Image = Resources.Resources.PlusBlue;
            removeToolStripButton.Image = Resources.Resources.MinusBlue;
            saveToolStripButton.Image = Resources.Resources.Save;
            cancelToolStripButton.Image = Resources.Resources.Delete;
            exportToolStripSplitButton.Image = Resources.Resources.Export;
        }

        protected void SetImages(List<string> Files)
        {
            this.images = new List<string>();

            mainListView.Items.Clear();
            imagesImageList.Images.Clear();

            this.AddImages(Files);
        }

        protected void AddImages(List<string> Files)
        {
            Files = this.FilterImages(Files);
            if (Files.Count == 0)
            {
                return;
            }

            this.images.AddRange(Files);

            int currentImage = 0;

            for (int i = this.images.Count - Files.Count; i < this.images.Count; i++)
            {
                imagesImageList.Images.Add(System.Drawing.Image.FromFile(Files[currentImage]));

                currentImage++;

                ListViewItem item = new ListViewItem()
                {
                    ImageIndex = i
                };

                mainListView.Items.Add(item);
            }
        }

        protected List<string> FilterImages(List<string> Images)
        {
            List<string> items = new List<string>();

            string[] extensions = new string[] { "jpg", "png", "gif", "bmp", "tiff" };

            for (int i = 0; i < Images.Count; i++)
            {
                for (int k = 0; k < extensions.Length; k++)
                {
                    if (Images[i].ToLower().EndsWith(extensions[k]))
                    {
                        items.Add(Images[i]);
                        break;
                    }
                }
            }

            return items;
        }

        protected void RemoveImages(List<int> Indexes)
        {
            for (int i = Indexes.Count - 1; i >= 0; i--)
            {
                this.images.RemoveAt(Indexes[i]);
            }

            this.SetImages(this.images);
        }

        protected void ClearImages()
        {
            mainListView.Items.Clear();
            imagesImageList.Images.Clear();
        }

        protected void Save(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            (Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages] as Image).Items.Clear();

            for (int i = 0; i < this.images.Count; i++)
            {
                (Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages] as Image).Items.Add(new File(FileType.Image, this.images[i]));
            }
        }

        protected void AddFile(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.ShowDialog();
            if (mainOpenFileDialog.FileName == string.Empty)
            {
                return;
            }

            // Adding files to List
            this.AddImages(mainOpenFileDialog.FileNames.ToList());
        }

        protected void Remove(object sender, EventArgs e)
        {
            this.RemoveSelectedImages();
        }

        protected void Cancel(object sender, EventArgs e)
        {
            this.UpdateControl();
        }

        protected bool Initialized { get; set; }

        public void UpdateControl()
        {
            if (!this.Initialized)
            {
                this.OnLoad(EventArgs.Empty);
            }

            this.images = new List<string>();

            this.ClearImages();

            mainListView.Enabled = this.CanExecuteAction;

            if (!this.CanExecuteAction)
            {
                return;
            }

            this.AddImages(Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items.Select(item => item.Path).ToList());
        }

        protected void RemoveSelectedImages()
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            List<int> indexes = new List<int>();
            for (int i = 0; i < mainListView.SelectedIndices.Count; i++)
            {
                indexes.Add(mainListView.SelectedIndices[i]);
            }

            indexes.Sort();
            this.RemoveImages(indexes);
        }

        protected void mainListViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.RemoveSelectedImages();
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < mainListView.Items.Count; i++)
                {
                    mainListView.Items[i].Selected = true;
                }
            }
        }

        protected void ExportAll(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            for (int i = 0; i < Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items.Count; i++)
            {
                try
                {
                    IO.File.Copy(Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[i].Path, IO.Path.Combine(mainFolderBrowserDialog.SelectedPath, Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[i].Path.Substring(Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[i].Path.LastIndexOf(@"\") + 1)));
                }
                catch (Exception) { }
            }
        }

        protected void ExportSelected(object sender, EventArgs e)
        {
            if (!this.CanExecuteAction)
            {
                return;
            }

            List<int> imageIndexes = new List<int>();
            for (int i = 0; i < mainListView.SelectedIndices.Count; i++)
            {
                imageIndexes.Add(mainListView.SelectedIndices[i]);
            }

            imageIndexes.Sort();

            if (imageIndexes.Count == 0)
            {
                return;
            }

            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            for (int i = 0; i < imageIndexes.Count; i++)
            {
                try
                {
                    IO.File.Copy(Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[imageIndexes[i]].Path, IO.Path.Combine(mainFolderBrowserDialog.SelectedPath, Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[imageIndexes[i]].Path.Substring(Core.Core.Instanse.Data[this.SelectedWorkSpace].Images[this.SelectedImages].Items[imageIndexes[i]].Path.LastIndexOf(@"\") + 1)));
                }
                catch (Exception) { }
            }
        }

        private void AddDirectory(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.SelectedPath = string.Empty;
            mainFolderBrowserDialog.ShowDialog();
            if (mainFolderBrowserDialog.SelectedPath == string.Empty)
            {
                return;
            }

            // Adding files to List
            this.AddImages(IO.Directory.GetFiles(mainFolderBrowserDialog.SelectedPath, "*", IO.SearchOption.AllDirectories).ToList());
        }
    }
}
