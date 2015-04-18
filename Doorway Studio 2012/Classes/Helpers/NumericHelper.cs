namespace Umax.Classes.Helpers
{
    public static class NumericHelper
    {
        public static string ToLongString(this int Number)
        {
            return Number.ToLongString(7);
        }

        public static string ToLongString(this int Number, int Length)
        {
            string longString = Number.ToString();

            while (longString.Length < Length)
            {
                longString = "0" + longString;
            }

            return longString;
        }
    }
}
