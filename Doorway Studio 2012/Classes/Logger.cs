using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Interfaces.Events;
using IO = System.IO;

namespace Umax.Classes
{
    public class Logger
    {
        public List<string> Items { get; protected set; }

        public string Log
        {
            get
            {
                return Items.AsString(Environment.NewLine);
            }
        }

        public Logger()
        {
            this.Items = new List<string>();
        }


        public void Append(string Message, LogMessageType Type)
        {
            string typeString = string.Empty;
            switch (Type)
            {
                case LogMessageType.Info:
                    {
                        typeString = "Information";
                        break;
                    }

                case LogMessageType.Warning:
                    {
                        typeString = "Warning";
                        break;
                    }

                case LogMessageType.Error:
                    {
                        typeString = "Error";
                        break;
                    }
            }

            this.Append(string.Format("[{0}] {1}: {2}", DateTime.Now.ToString(), typeString, Message));
        }

        public void Append(Exception Exception)
        {
            StringBuilder stringBuilder = new StringBuilder();
            do
            {
                stringBuilder.AppendLine(Exception.Message + Exception.StackTrace);
                Exception = Exception.InnerException;
            } while (Exception != null);

            this.Append(string.Format("[{0}] Error: {1}", DateTime.Now.ToString(), stringBuilder.ToString()));
        }

        protected void Append(string Message)
        {
            this.Items.Add(Message);

            this.InvokeEvents(Message);
        }

        protected virtual void InvokeEvents(string Entry)
        {
            if (this.Added != null)
            {
                this.Added.Invoke(Entry);
            }

            if (this.Changed != null)
            {
                this.Changed.Invoke();
            }
        }

        public virtual void Save()
        {
            this.Save(IO.Path.Combine(IO.Path.Combine(Application.StartupPath, "Log"), "Log [Date].log"));
        }

        public virtual void Save(string Path)
        {
            if (this.Items.Count == 0)
            {
                return;
            }

            try
            {
                Path = Path.Replace("[Date]", DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" ")).Replace("/", "-"));
                Path = Path.Replace("/", string.Empty).Replace("*", string.Empty).Replace("?", string.Empty).Replace("\"", string.Empty).Replace("<", string.Empty)
                    .Replace(">", string.Empty).Replace("|", string.Empty);

                IOHelper.CreateDirectory(new IO.FileInfo(Path).DirectoryName);

                IO.File.AppendAllText(Path, this.Log + Environment.NewLine, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                this.Append(ex);
            }
        }

        public event SimpleEventHandler Changed;
        public event SimpleSenderEventHandler Added;
    }
}
