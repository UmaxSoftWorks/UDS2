using System;
using System.Collections.Generic;
using System.Text;
using Umax.Classes.Enums;

namespace Umax.Classes.Helpers
{
    public static class StringListHelper
    {
        /// <summary>
        /// Returns, if any of list items contains specified item
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool ContainsString(this List<string> Items, string Item)
        {
            return Items.ContainsString(Item, false);
        }

        /// <summary>
        /// Returns, if any of list items contains specified item (ignore case)
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static bool ContainsString(this List<string> Items, string Item, bool IgnoreCase)
        {
            return Items.ContainsString(Item, 0, IgnoreCase);
        }

        /// <summary>
        /// Returns, if any of list items contains specified item starting from start index
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="StartIndex"></param>
        /// <returns></returns>
        public static bool ContainsString(this List<string> Items, string Item, int StartIndex)
        {
            return Items.ContainsString(Item, 0, false);
        }

        /// <summary>
        /// Returns, if any of list items contains specified item starting from start index
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="StartIndex"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static bool ContainsString(this List<string> Items, string Item, int StartIndex, bool IgnoreCase)
        {
            for (int i = StartIndex; i < Items.Count; i++)
            {
                if (IgnoreCase ? Items[i].ToLower().Contains(Item.ToLower()) : Items[i].Contains(Item))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns, if any of list items equals specified string
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static bool Contains(this List<string> Items, string Item, bool IgnoreCase)
        {
            return Items.Contains(Item, 0, IgnoreCase);
        }

        /// <summary>
        /// Returns, if any of list items equals specified string starting from start index
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="StartIndex"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns></returns>
        public static bool Contains(this List<string> Items, string Item, int StartIndex, bool IgnoreCase)
        {
            for (int i = StartIndex; i < Items.Count; i++)
            {
                if (IgnoreCase ? Items[i].ToLower() == Item.ToLower() : Items[i] == Item)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns index of item, which contains specified item. If there is no such item in the list, than returned index is -1
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static int IndexOfString(this List<string> Items, string Item)
        {
            return Items.IndexOfString(Item, 0);
        }

        /// <summary>
        /// Returns index of item, which contains specified item. If there is no such item in the list, than returned index is -1, starting from start index
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="StartIndex"></param>
        /// <returns></returns>
        public static int IndexOfString(this List<string> Items, string Item, int StartIndex)
        {
            for (int i = StartIndex; i < Items.Count; i++)
            {
                if (Items[i].Contains(Item))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Returns number of items contained in the list
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static int ContainsStringCount(this List<string> Items, string Item)
        {
            return Items.ContainsStringCount(Item, 0);
        }

        /// <summary>
        /// Returns number of items contained in the list start from start index
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Item"></param>
        /// <param name="StartIndex"></param>
        /// <returns></returns>
        public static int ContainsStringCount(this List<string> Items, string Item, int StartIndex)
        {
            int count = 0;

            int index = StartIndex;
            do
            {
                index = Items.IndexOfString(Item, index);
                if (index != -1)
                {
                    count++;
                    index++;
                }
            } while (index != -1);

            return count;
        }

        /// <summary>
        /// Swaps two items in the list
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="IndexOne"></param>
        /// <param name="IndexTwo"></param>
        public static void Swap(this List<string> Items, int IndexOne, int IndexTwo)
        {
            if (IndexOne < 0 || Items.Count < IndexOne || IndexTwo < 0 || Items.Count < IndexTwo || IndexOne == IndexTwo)
            {
                return;
            }

            string item = Items[IndexOne];
            Items[IndexOne] = Items[IndexTwo];
            Items[IndexTwo] = item;
        }

        /// <summary>
        /// Convert all items in the list to one line string
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public static string AsString(this List<string> Items)
        {
            return Items.AsString(" ");
        }

        /// <summary>
        /// Convert all items in the list to one line string
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string AsString(this List<string> Items, string Separator)
        {
            StringBuilder builder = new StringBuilder(Items.Count * 10);

            for (int i = 0; i < Items.Count; i++)
            {
                builder.Append(Items[i] + ((i + 1 == Items.Count) ? string.Empty : Separator));
            }

            return builder.ToString();
        }

        public static List<string> Split(this List<string> Items, StringSplitType Type)
        {
            return Items.Split(Type, StringSplitOptions.RemoveEmptyEntries);
        }

        public static List<string> Split(this List<string> Items, StringSplitType Type, StringSplitOptions Options)
        {
            switch (Type)
            {
                case StringSplitType.Word:
                    {
                        return Items.SplitWords(Options);
                    }

                case StringSplitType.Fragment:
                    {
                        return Items.SplitFragment(Options);
                    }

                case StringSplitType.Sentence:
                    {
                        return Items.SplitSentence(Options);
                    }

                case StringSplitType.Line:
                    {
                        return Items.SplitLine(Options);
                    }
            }

            return Items.SplitWords(Options);
        }

        internal static List<string> SplitWords(this List<string> Items, StringSplitOptions Options)
        {
            List<string> list = new List<string>(Items.Count);

            for (int i = 0; i < Items.Count; i++)
            {
                list.AddRange(Items[i].Split(new char[] { ' ' }, Options));
            }

            return list;
        }

        internal static List<string> SplitFragment(this List<string> Items, StringSplitOptions Options)
        {
            List<string> list = new List<string>(Items.Count);

            for (int i = 0; i < Items.Count; i++)
            {
                list.AddRange(Items[i].Split(new string[] { ":", ";", ",", ".", "?", "!" }, Options));
            }

            return list;
        }

        internal static List<string> SplitSentence(this List<string> Items, StringSplitOptions Options)
        {
            List<string> list = new List<string>(Items.Count);

            for (int i = 0; i < Items.Count; i++)
            {
                list.AddRange(Items[i].Split(new string[] { "...", ".", "?", "!" }, Options));
            }

            return list;
        }

        internal static List<string> SplitLine(this List<string> Items, StringSplitOptions Options)
        {
            List<string> list = new List<string>(Items.Count);

            for (int i = 0; i < Items.Count; i++)
            {
                list.AddRange(Items[i].Split(new string[] { "\r\n", "\n", "\r" }, Options));
            }

            return list;
        }

        public static List<string> ToLower(this List<string> Items)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i] = Items[i].ToLower();
            }

            return Items;
        }

        /// <summary>
        /// Cut specified list
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="Count">Number of items to be in output list</param>
        /// <returns></returns>
        public static List<string> Cut(this List<string> Items, int Count)
        {
            return Items.Cut(0, Count);
        }

        /// <summary>
        /// Cut specified list
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="StartIndex">Start index to cut with</param>
        /// <param name="Count">Number of items to be in output list</param>
        /// <returns></returns>
        public static List<string> Cut(this List<string> Items, int StartIndex, int Count)
        {
            if (StartIndex < 0)
            {
                StartIndex = 0;
            }

            if (Items.Count < StartIndex)
            {
                StartIndex = 0;
            }

            if (Items.Count < Count)
            {
                return Items;
            }

            List<string> items = new List<string>(Count);
            for (int i = StartIndex; i < StartIndex + Count; i++)
            {
                items.Add(Items[i]);
            }

            return items;
        }
    }
}
