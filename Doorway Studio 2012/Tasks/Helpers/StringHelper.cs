using System;
using System.Collections.Generic;

namespace Umax.Plugins.Tasks.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Generates different keywords based on input
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static List<string> Combinations(this string Item)
        {
            string[] parts = Item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2 || parts.Length > 5)
            {
                return new List<string>() { Item };
            }

            List<string> items = new List<string>();

            if (parts.Length == 2)
            {
                items.Add(parts[0] + " " + parts[1]);
                items.Add(parts[1] + " " + parts[0]);
            }
            else if (parts.Length == 3)
            {
                items.Add(parts[0] + " " + parts[1] + " " + parts[2]);
                items.Add(parts[0] + " " + parts[2] + " " + parts[1]);
                items.Add(parts[1] + " " + parts[0] + " " + parts[2]);
                items.Add(parts[1] + " " + parts[2] + " " + parts[0]);
                items.Add(parts[2] + " " + parts[0] + " " + parts[1]);
                items.Add(parts[2] + " " + parts[1] + " " + parts[0]);
            }
            else if (parts.Length == 4)
            {
                items.Add(parts[0] + " " + parts[1] + " " + parts[2] + " " + parts[3]);
                items.Add(parts[0] + " " + parts[1] + " " + parts[3] + " " + parts[2]);
                items.Add(parts[0] + " " + parts[2] + " " + parts[1] + " " + parts[3]);
                items.Add(parts[0] + " " + parts[2] + " " + parts[3] + " " + parts[1]);
                items.Add(parts[0] + " " + parts[3] + " " + parts[1] + " " + parts[2]);
                items.Add(parts[0] + " " + parts[3] + " " + parts[2] + " " + parts[1]);
                items.Add(parts[1] + " " + parts[0] + " " + parts[2] + " " + parts[3]);
                items.Add(parts[1] + " " + parts[0] + " " + parts[3] + " " + parts[2]);
                items.Add(parts[1] + " " + parts[2] + " " + parts[0] + " " + parts[3]);
                items.Add(parts[1] + " " + parts[2] + " " + parts[3] + " " + parts[0]);
                items.Add(parts[1] + " " + parts[3] + " " + parts[0] + " " + parts[2]);
                items.Add(parts[1] + " " + parts[3] + " " + parts[2] + " " + parts[0]);
                items.Add(parts[2] + " " + parts[0] + " " + parts[1] + " " + parts[3]);
                items.Add(parts[2] + " " + parts[0] + " " + parts[3] + " " + parts[1]);
                items.Add(parts[2] + " " + parts[1] + " " + parts[0] + " " + parts[3]);
                items.Add(parts[2] + " " + parts[1] + " " + parts[3] + " " + parts[0]);
                items.Add(parts[2] + " " + parts[3] + " " + parts[0] + " " + parts[1]);
                items.Add(parts[2] + " " + parts[3] + " " + parts[1] + " " + parts[0]);
                items.Add(parts[3] + " " + parts[0] + " " + parts[1] + " " + parts[2]);
                items.Add(parts[3] + " " + parts[0] + " " + parts[2] + " " + parts[1]);
                items.Add(parts[3] + " " + parts[1] + " " + parts[0] + " " + parts[2]);
                items.Add(parts[3] + " " + parts[1] + " " + parts[2] + " " + parts[0]);
                items.Add(parts[3] + " " + parts[2] + " " + parts[0] + " " + parts[1]);
                items.Add(parts[3] + " " + parts[2] + " " + parts[1] + " " + parts[0]);
            }

            return items;
        }
    }
}
