using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IO = System.IO;

namespace Core.Classes
{
    public class Logger : Umax.Classes.Logger
    {
        private static Logger instanse;

        public static Logger Instanse
        {
            get { return instanse ?? (instanse = new Logger()); }
        }

        /// <summary>
        /// A value indicating whether use options or not
        /// </summary>
        public bool UseOptions { get; set; }

        protected Logger()
        {

        }

        protected override void InvokeEvents(string Entry)
        {
            base.InvokeEvents(Entry);

            if ((this.UseOptions ? Options.Instanse.LogMaxSize : 100) <= this.Items.Count)
            {
                this.Save();

                this.Items = new List<string>();
            }
        }

        public override void Save()
        {
            try
            {
                // Depends on Setting's log file name, save log
                if (Options.Instanse.LogSave)
                {
                    if (Options.Instanse.LogDirectory == string.Empty)
                    {
                        Options.Instanse.LogDirectory = IO.Path.Combine(Application.StartupPath, "Log");
                    }

                    if (!IO.Path.IsPathRooted(Options.Instanse.LogDirectory))
                    {
                        Options.Instanse.LogDirectory = IO.Path.Combine(Application.StartupPath, Options.Instanse.LogDirectory);
                    }

                    this.Save(IO.Path.Combine(Options.Instanse.LogDirectory, Options.Instanse.LogFileName));
                }
            }
            catch (Exception ex)
            {
                this.Append(ex);
            }
        }
    }
}
