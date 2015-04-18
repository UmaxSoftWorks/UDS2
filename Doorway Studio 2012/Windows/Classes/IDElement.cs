namespace Umax.Windows.Classes
{
    public class IDElement
    {
        public IDElement()
        {
            this.ID = 0;
            this.Text = string.Empty;
        }

        public IDElement(int ID, string Text)
        {
            this.ID = ID;
            this.Text = Text;
        }

        public int ID { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                return string.Empty;
            }

            return this.Text;
        }
    }
}
