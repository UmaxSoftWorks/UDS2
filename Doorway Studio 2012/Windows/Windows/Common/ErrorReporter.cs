using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Core.Classes;
using Umax.Windows.Classes;
using Umax.Windows.Helpers;

namespace Umax.Windows.Windows.Common
{
    public partial class ErrorReporter : Form
    {
        public ErrorReporter()
        {
            InitializeComponent();
        }

        public ErrorReporter(Exception Exception)
            : this()
        {
            messageTextBox.Text = Exception.Message;
            detailsTextBox.Text = Exception.StackTrace;

            while (Exception.InnerException != null)
            {
                Exception = Exception.InnerException;
                detailsTextBox.Text += "\r\n Inner Exception: " + Exception.Message + Exception.StackTrace;
            }
        }

        private void CriticalErrorReporterLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Brand.Name + " " + this.Text;

            this.InitializeImages();

            logTextBox.Text = Logger.Instanse.Log;

            if (Core.Core.Instanse.Manager != null)
            {
                Core.Core.Instanse.Manager.Close();
            }

            mainTimer.Start();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;
            mainPictureBox.Image = Resources.Resources.Error;
        }

        private int tickCount { get; set; }

        private void okButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.tickCount++;

            if (this.tickCount >= 60)
            {
                this.Close();
            }

            timeToCloseCountLabel.Text = (60 - this.tickCount).ToString();
        }

        private void CriticalErrorReporterFormClosing(object sender, FormClosingEventArgs e)
        {
            GuiOptions options = GuiOptions.Instanse;

            // Save log
            try
            {
                File.AppendAllText(Path.Combine(Application.StartupPath, "Report " + DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" ")).Replace("/", "-")  + ".log"), messageTextBox.Text + detailsTextBox.Text, Encoding.UTF8);
            }
            catch (Exception) { }

            // Report by Mail
            if (options.ReportRnD)
            {
                switch (Brand.Brand.Name)
                {
                    case "Umax":
                        {
                            this.SendMail("umaxsoft@gmail.com", "uds@mail.ru", "Error: UDS 2012 " + DateTime.Now.ToString(), "Error: UDS 2012 " + DateTime.Now.ToString(), "smtp.mail.ru", 25, "login", "password", true);
                            break;
                        }
                }
            }

            // Report to user
            if (options.Report)
            {
                this.SendMail(options.ReportTo, options.ReportFrom, options.ReportSubject, options.ReportMessage, options.ReportHost, options.ReportPort, options.ReportLogin, options.ReportPassword, options.ReportAttachments);
            }

            this.Invoke((MethodInvoker) delegate() { Helper.Exit(); });
        }

        private void SendMail(string To, string From, string Subject, string Message, string Host, int Port, string Login, string Password, bool Attachements)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();

                // To
                mailMsg.To.Add(To);

                // From
                mailMsg.From = new MailAddress(From);

                // Subject and Body
                mailMsg.Subject = Subject.Replace("[Date]", DateTime.Now.ToString());
                mailMsg.Body = Message.Replace("[Date]", DateTime.Now.ToString());

                // Attachments
                if (Attachements)
                {
                    List<string> logs = this.Logs();
                    for (int i = 0; i < logs.Count; i++)
                    {
                        mailMsg.Attachments.Add(new Attachment(logs[i]));
                    }
                }

                // Init SmtpClient and send
                SmtpClient smtpClient = new SmtpClient(Host, Port);
                smtpClient.Credentials = new System.Net.NetworkCredential(Login, Password);

                smtpClient.Send(mailMsg);
            }
            catch (Exception) { }
        }

        private List<string> Logs()
        {
            List<string> logs = new List<string>();

            if (File.Exists(Path.Combine(Application.StartupPath, "Report " + DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" ")).Replace("/", "-") + ".log")))
            {
                logs.Add(Path.Combine(Application.StartupPath, "Report " + DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" ")).Replace("/", "-") + ".log"));
            }

            if (Core.Core.Instanse.Options.LogSave)
            {
                string logDirectory = Core.Core.Instanse.Options.LogDirectory;
                if (logDirectory == string.Empty)
                {
                    logDirectory = Application.StartupPath;
                }

                string logName = Core.Core.Instanse.Options.LogFileName;
                logName = logName.Replace("[Date]", DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(" ")).Replace("/", "-"));
                logName = logName.Replace("\\", string.Empty).Replace("/", string.Empty).Replace(":", string.Empty).Replace("*", string.Empty)
                    .Replace("?", string.Empty).Replace("\"", string.Empty).Replace("<", string.Empty).Replace(">", string.Empty).Replace("|", string.Empty);
                if (File.Exists(Path.Combine(logDirectory, logName)))
                {
                    logs.Add(Path.Combine(logDirectory, logName));
                }
            }

            return logs;
        }

        private void TimeToCloseLabel(object sender, EventArgs e)
        {
            mainTimer.Stop();
        }

        private void timeToCloseCountLabelClick(object sender, EventArgs e)
        {
            mainTimer.Stop();
        }
    }
}
