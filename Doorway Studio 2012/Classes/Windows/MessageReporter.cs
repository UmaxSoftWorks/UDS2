using System;
using System.Windows.Forms;
using Umax.Classes.Enums;

namespace Umax.Classes.Windows
{
    public partial class MessageReporter : Form
    {
        public MessageReporter()
        {
            this.messageType = MessageType.Warning;

            InitializeComponent();
        }

        private MessageType messageType;

        public MessageReporter(string Message, string Details, MessageType Type)
            : this()
        {
            messageTextBox.Text = Message;
            detailsTextBox.Text = Details;
            this.messageType = Type;
        }

        public MessageReporter(Exception Exception, MessageType Type)
            : this()
        {
            messageTextBox.Text = Exception.Message;
            detailsTextBox.Text = Exception.StackTrace;

            while (Exception.InnerException != null)
            {
                Exception = Exception.InnerException;
                detailsTextBox.Text += "\r\n Inner Exception: " + Exception.Message + Exception.StackTrace;
            }

            this.messageType = Type;
        }

        private void MessageReporterLoad(object sender, EventArgs e)
        {
            this.Text = Brand.Brand.Name + " " + this.Text;
            this.InitializeImages();
        }

        protected void InitializeImages()
        {
            this.Icon = Resources.Resources.IconRed;

            switch (this.messageType)
            {
                case MessageType.Information:
                    {
                        mainPictureBox.Image = Resources.Resources.Info;
                        break;
                    }

                case MessageType.Warning:
                    {
                        mainPictureBox.Image = Resources.Resources.Exclamation;
                        break;
                    }

                case MessageType.Error:
                    {
                        mainPictureBox.Image = Resources.Resources.Error;
                        break;
                    }
            }
        }
    }
}
