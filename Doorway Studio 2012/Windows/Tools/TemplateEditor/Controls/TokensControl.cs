using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Core.Enums;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Events;
using Umax.Interfaces.TemplateEditor;
using Umax.Interfaces.Tokens;
using Umax.UI.XPListBox;
using Umax.Windows.Tools.TemplateEditor.Classes;

namespace Umax.Windows.Tools.TemplateEditor.Controls
{
    public partial class TokensControl : UserControl
    {
        private List<XPListBoxGroup> listBoxGroups;

        /// <summary>
        /// Gets or sets list of tokens
        /// </summary>
        public List<IToken> Items { get; private set; }

        public TokensControl()
        {
            InitializeComponent();

            this.Items = new List<IToken>();
        }

        private void LoadTokens()
        {
            for (int i = 0; i < Core.Core.Instanse.Tokens.Items.Count; i++)
            {
                this.Items.Add(Core.Core.Instanse.Tokens.Items[i]);
            }

            this.LoadDll("Images");
            this.LoadDll("Text");
            this.LoadDll("Tasks");

            if (File.Exists(Path.Combine(Core.Core.MainPath, "Plus.dll")))
            {
                this.LoadDll("Plus");
            }
        }

        public void LoadDll(string DllPath)
        {
            Assembly assembly = Assembly.Load(DllPath);
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                try
                {
                    if (types[i].Name.Contains("SimpleToken") && types[i].Attributes == TypeAttributes.BeforeFieldInit)
                    {
                        this.Items.Add(assembly.CreateInstance(types[i].FullName) as ISimpleToken);
                    }
                    else if (types[i].Name.Contains("ComplexToken") && types[i].Attributes == TypeAttributes.BeforeFieldInit)
                    {
                        this.Items.Add(assembly.CreateInstance(types[i].FullName) as IComplexToken);
                    }
                }
                catch (Exception) { }
            }
        }

        private void TokensControlLoad(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            this.LoadTokens();

            this.listBoxGroups = new List<XPListBoxGroup>();

            this.InitializeImages();
            this.Initialize();

            this.UpdateControl();
        }

        protected void InitializeImages()
        {
            // Complex token
            mainImageList.Images.Add(Resources.Resources.ComponentYellow);
            
            // Simple token
            mainImageList.Images.Add(Resources.Resources.ComponentGreen);

            // Category token
            mainImageList.Images.Add(Resources.Resources.ComponentBlue);
        }

        protected void Initialize()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                this.InitializeToken(this.Items[i]);
            }
        }

        protected void InitializeToken(IToken Token)
        {
            TokenInfo tag = new TokenInfo();

            tag.Token = Token;
            tag.Name = Token.Name;
            tag.Category = "Misc";

            if (Token is ITokenTemplateEditorCompatible)
            {
                tag.Description = (Token as ITokenTemplateEditorCompatible).Description(LanguageType.English);
                tag.Category = (Token as ITokenTemplateEditorCompatible).Group;
            }

            XPListBoxItem token = new XPListBoxItem(tag.Name, !(Token is ISimpleToken) ? 0 : 1)
                                      {
                                          Tag = tag
                                      };

            bool added = false;
            for (int k = 0; k < this.listBoxGroups.Count; k++)
            {
                if (this.listBoxGroups[k].Text == (token.Tag as TokenInfo).Category)
                {
                    added = true;
                    this.listBoxGroups[k].Items.Add(token);
                    break;
                }
            }

            if (!added)
            {
                XPListBoxGroup group = new XPListBoxGroup((token.Tag as TokenInfo).Category, 2);
                group.Items.Add(token);

                this.listBoxGroups.Add(group);
            }
        }

        protected void UpdateControl()
        {
            mainListBox.Items.Clear();

            for (int i = 0; i < this.listBoxGroups.Count; i++)
            {
                if (!this.listBoxGroups[i].Visible && searchTextBox.Text != string.Empty)
                {
                    continue;
                }

                mainListBox.Items.Add(this.listBoxGroups[i]);

                for (int k = 0; k < this.listBoxGroups[i].Items.Count; k++)
                {
                    if (this.listBoxGroups[i].Items[k].Visible)
                    {
                        mainListBox.Items.Add(this.listBoxGroups[i].Items[k]);
                    }
                }
            }

            descriptionTextBox.Text = string.Empty;
        }

        private void searchPictureBoxClick(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void searchTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                for (int i = 0; i < this.listBoxGroups.Count; i++)
                {
                    for (int k = 0; k < this.listBoxGroups[i].Items.Count; k++)
                    {
                        this.listBoxGroups[i].Items[k].Visible = true;
                    }
                }

                this.UpdateControl();
                return;
            }

            for (int i = 0; i < this.listBoxGroups.Count; i++)
            {
                for (int k = 0; k < this.listBoxGroups[i].Items.Count; k++)
                {
                    this.listBoxGroups[i].Items[k].Visible = this.listBoxGroups[i].Items[k].Text.Contains(StringContainsType.Any, true, searchTextBox.Text);
                }
            }

            this.UpdateControl();
        }

        private void mainListBoxSelectedValueChanged(object sender, EventArgs e)
        {
            if (((XPListBox)sender).SelectedItem is XPListBoxGroup)
            {
                if (searchTextBox.Text == string.Empty)
                {
                    int index = ((XPListBox) sender).SelectedIndex;

                    (((XPListBox) sender).SelectedItem as XPListBoxGroup).Visible = !(((XPListBox) sender).SelectedItem as XPListBoxGroup).Visible;
                    
                    this.UpdateControl();

                    this.mainListBox.TopIndex = index;
                }
            }
            else if (((XPListBox)sender).SelectedItem is XPListBoxItem)
            {
                XPListBoxItem item = (((XPListBox) sender).SelectedItem as XPListBoxItem);

                for (int i = 0; i < this.listBoxGroups.Count; i++)
                {
                    if (this.listBoxGroups[i].Items.Contains(item))
                    {
                        this.SelectedToken = (this.listBoxGroups[i].Items[this.listBoxGroups[i].Items.IndexOf(item)].Tag as TokenInfo).Token;
                        descriptionTextBox.Text = (this.listBoxGroups[i].Items[this.listBoxGroups[i].Items.IndexOf(item)].Tag as TokenInfo).Description;

                        if (this.TokenSelected != null)
                        {
                            this.TokenSelected();
                        }
                    }
                }
            }
        }

        public IToken SelectedToken { get; private set; }

        public event SimpleEventHandler TokenSelected;
    }
}
