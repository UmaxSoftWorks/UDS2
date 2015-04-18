using System;
using System.Windows.Forms;
using Umax.Classes.Ini;
using Umax.Interfaces.Enums;
using System.IO;

namespace WebParser.Classes
{
    class GuiOptions
    {
        #region Data
        public LanguageType Language { get; set; }

        public bool NoFxCheck { get; set; }

        #endregion

        #region Methods

        protected static GuiOptions instanse;

        public static GuiOptions Instanse
        {
            get { return instanse ?? (instanse = new GuiOptions()); }
        }

        protected GuiOptions()
        {
            // Loading Options
            if (File.Exists(Path.Combine(Application.StartupPath, "GUI.ini")))
            {
                IniWorker ini = new IniWorker(Path.Combine(Application.StartupPath, "GUI.ini"));
                try
                {
                    // General
                    string iniGroup = "General";
                    try
                    {
                        this.Language = (LanguageType)Enum.Parse(typeof(LanguageType), ini.IniReadValue(iniGroup, "Language"), true);
                    }
                    catch (Exception)
                    {
                        this.Language = LanguageType.English;
                    }

                    if (!this.NoFxCheck)
                    {
                        this.NoFxCheck = bool.Parse(ini.IniReadValue(iniGroup, "NoFxCheck"));
                    }
                }
                catch (Exception)
                {
                    this.ApplyDefaultOptions();
                }
            }
            else
            {
                this.ApplyDefaultOptions();
            }
        }

        protected void ApplyDefaultOptions()
        {
            // General
            this.Language = LanguageType.English;
            this.NoFxCheck = false;
        }

        public void Save()
        {
            try
            {
                if (File.Exists(Path.Combine(Application.StartupPath, "GUI.ini")))
                {
                    // Removing readonly
                    FileInfo file = new FileInfo(Path.Combine(Application.StartupPath, "GUI.ini"));
                    file.Attributes = FileAttributes.Normal;
                }

                // Saving
                IniWorker ini = new IniWorker(Path.Combine(Application.StartupPath, "GUI.ini"));
                string iniGroup = string.Empty;

                // General
                iniGroup = "General";
                ini.IniWriteValue(iniGroup, "Language", this.Language.ToString());
                ini.IniWriteValue(iniGroup, "NoFxCheck", this.NoFxCheck.ToString());
            }
            catch (Exception) { }
        }
        #endregion
    }
}
