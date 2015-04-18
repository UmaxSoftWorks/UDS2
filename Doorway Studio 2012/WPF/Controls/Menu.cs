using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using Umax.Windows.Enums;
using Umax.Windows.Interfaces;
using Umax.WPF.Helpers;
using MenuItem = System.Windows.Controls.MenuItem;
using MenuStrip = Umax.Windows.Controls.MenuStrip;

namespace Umax.WPF.Controls
{
    public partial class Menu : System.Windows.Controls.Menu, IEventedControl
    {
        protected MenuStrip menuStrip;

        protected Dictionary<MenuItem, ToolStripItem> menuItems;

        public Menu()
        {
            this.menuStrip = new MenuStrip();
            
            this.InitializeEvents();
        }

        void MenuLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuStrip.Changed += this.UpdateControl;

            this.UpdateControl();
        }

        private MainMenuType menuType;
        public MainMenuType MenuType
        {
            get { return this.menuType; }
            set { this.menuType = value; }
        }

        protected object AddMenuItem(ToolStripItem Item)
        {
            if (Item is ToolStripMenuItem)
            {
                MenuItem item = new MenuItem();

                if (Item.Image != null)
                {
                    item.Icon = new System.Windows.Controls.Image()
                                    {
                                        Source = ((Bitmap) Item.Image).ToBitmapSource(),
                                        Height = 16
                                    };
                }

                item.InputGestureText = this.ProcessShortcutKeys((Item as ToolStripMenuItem).ShortcutKeys);
                item.IsChecked = (Item as ToolStripMenuItem).Checked;

                item.Header = Item.Text.Replace("&", "_");


                item.Click += this.MenuClick;

                foreach (ToolStripItem subItem in (Item as ToolStripMenuItem).DropDownItems)
                {
                    if (subItem.Enabled)
                    {
                        item.Items.Add(this.AddMenuItem(subItem));
                    }
                }

                this.menuItems.Add(item, Item);

                return item;
            }

            return new Separator();
        }

        private string ProcessShortcutKeys(Keys Keys)
        {
            if (Keys == Keys.None)
            {
                return string.Empty;
            }

            string[] keys = Keys.ToString().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string key = string.Empty;
            string result = string.Empty;
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Length == 1)
                {
                    key = keys[i];
                }
                else
                {
                    result += keys[i] + "+";
                }
            }

            result += key;

            return result.Replace("Control", "Ctrl");
        }

        protected void MenuClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is MenuItem)
            {
                try
                {
                    this.menuItems[sender as MenuItem].PerformClick();
                }
                catch (Exception) { }
            }
        }

        public void InitializeEvents()
        {
            this.Loaded += this.MenuLoaded;
        }

        public void DeInitializeEvents()
        {
            this.menuStrip.DeInitializeEvents();
        }

        public void UpdateControl()
        {
            this.Items.Clear();

            this.menuStrip.MenuType = this.MenuType;

            this.menuItems = new Dictionary<MenuItem, ToolStripItem>();

            foreach (ToolStripItem item in this.menuStrip.Items)
            {
                this.Items.Add(this.AddMenuItem(item));
            }
        }
    }
}
