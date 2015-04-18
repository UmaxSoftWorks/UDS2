using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Umax.Classes.Tokens
{
    public abstract class MinMaxExtendableToken : ExtendableToken
    {
        public const int DefaultMinimum = 0;
        public const int DefaultMaximum = 10;

        public List<int> GetMinMaxExtensions(string Token)
        {
            return this.GetMinMaxExtensions(Token, DefaultMinimum, DefaultMaximum);
        }

        public List<int> GetMinMaxExtensions(string Token, int Minimum, int Maximum)
        {
            List<string> extensions = this.GetExtensions(Token);
            int minimum = Minimum;
            int maximum = Maximum;

            List<int> numbers = new List<int>();
            for (int i = 0; i < extensions.Count; i++)
            {
                int number = 0;
                if (int.TryParse(extensions[i], out number))
                {
                    numbers.Add(number);
                }
            }

            numbers.Sort();

            if (numbers.Count != 0)
            {
                if (numbers.Count == 1)
                {
                    maximum = numbers[0];
                }
                else
                {
                    minimum = numbers[0];
                    maximum = numbers[1];
                }
            }

            if (maximum < minimum)
            {
                maximum = minimum;
            }

            return new List<int>() { minimum, maximum };
        }

        public bool CheckMinMaxExtensions(string Token)
        {
            return Regex.IsMatch(Token, "[0-9]+");
        }
    }
}
