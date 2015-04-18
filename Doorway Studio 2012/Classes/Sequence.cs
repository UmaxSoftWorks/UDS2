namespace Umax.Classes
{
    public class Sequence
    {
        public Sequence()
            : this(0, int.MaxValue)
        {
        }

        public Sequence(int MaxValue)
            : this(0, MaxValue)
        {
        }

        public Sequence(int MinValue, int MaxValue)
        {
            this.Step = 1;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;

            this.InitializeValue();
        }

        protected virtual void InitializeValue()
        {
            this.Value = this.MinValue - 1;
        }

        private readonly object lockFlag = new object();

        /// <summary>
        /// Gets or sets a value indicating whether sequence is cyclic
        /// </summary>
        public bool Cyclic { get; set; }

        public int MinValue { get; protected set; }

        public int MaxValue { get; protected set; }

        public int Value { get; protected set; }

        public int Step { get; protected set; }

        public int Invoke()
        {
            lock (lockFlag)
            {
                if (this.Value == this.MaxValue && this.Cyclic)
                {
                    this.InitializeValue();
                }

                this.Value += this.Step;
                return this.Value;
            }
        }
    }
}
