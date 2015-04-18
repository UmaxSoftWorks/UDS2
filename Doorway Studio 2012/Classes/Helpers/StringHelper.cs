using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Umax.Classes.Enums;

namespace Umax.Classes.Helpers
{
    public static class StringHelper
    {
        public static string MakeRandom(int MinimumLength, int MaximumLength, StringCharactersType Characters)
        {
            switch (Characters)
            {
                case StringCharactersType.LowerCase:
                    {
                        return MakeRandom(MinimumLength, MaximumLength);
                    }

                case StringCharactersType.UpperCase:
                    {
                        return MakeRandom(MinimumLength, MaximumLength).ToUpper();
                    }

                case StringCharactersType.Numbers:
                    {
                        return MakeRandomNumeric(MinimumLength, MaximumLength);
                    }

                case StringCharactersType.Symbols:
                    {
                        return MakeRandomSymbol(MinimumLength, MaximumLength);
                    }
            }

            return String.Empty;
        }

        public static string MakeRandomSymbol(int MinimumLength, int MaximumLength)
        {
            Random random = new Random();

            int length = random.Next(MinimumLength, MaximumLength);

            StringBuilder stringBuilder = new StringBuilder(length);

            string[] symbols = new string[]
                                   {
                                       "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[",
                                       "]", "{", "}", "\\", "|", ";", ":", "'", "\"", ",", "<", ".", ">", "/", "?"
                                   };

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(symbols[random.Next(0, symbols.Length)]);
            }

            return stringBuilder.ToString();
        }

        public static string MakeRandomNumeric(int MinimumLength, int MaximumLength)
        {
            Random random = new Random();

            int length = random.Next(MinimumLength, MaximumLength);

            StringBuilder stringBuilder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(random.Next(0, 10).ToString());
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Generates random lowercase string
        /// </summary>
        /// <param name="MinimumLength"></param>
        /// <param name="MaximumLength"></param>
        /// <returns></returns>
        public static string MakeRandom(int MinimumLength, int MaximumLength)
        {
            Random random = new Random();

            int length = random.Next(MinimumLength, MaximumLength);

            StringBuilder stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(((char)random.Next((int)'a', (int)'z' + 1)).ToString());
            }

            return stringBuilder.ToString();
        }

        public static string Mix(this string Value)
        {
            Random random = new Random();

            // Split
            char[] characters = Value.ToCharArray();

            // Mix
            for (int i = 0; i < Value.Length; i++)
            {
                char character = characters[i];
                int index = random.Next(Value.Length);

                characters[i] = characters[index];
                characters[index] = character;
            }

            // Combine
            StringBuilder stringBuilder = new StringBuilder(Value.Length);

            for (int i = 0; i < Value.Length; i++)
            {
                stringBuilder.Append(characters[i]);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Transliterates string
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string Translite(this string Value)
        {
            StringBuilder stringBuilder = new StringBuilder(Value);

            // Lower case
            stringBuilder.Replace('а', 'a').Replace('б', 'b').Replace('в', 'v').Replace('г', 'g').Replace('ґ', 'g').Replace('д', 'd').Replace('е', 'e').Replace('э', 'e')
                .Replace('ё', 'e').Replace('є', 'e').Replace("ж", "zh").Replace('з', 'z').Replace('і', 'i').Replace('ї', 'i').Replace('и', 'i').Replace('й', 'y').Replace('ы', 'y')
                .Replace('к', 'k').Replace('л', 'l').Replace('м', 'm').Replace('н', 'n').Replace('о', 'o').Replace('п', 'p').Replace('р', 'r').Replace('с', 's').Replace('т', 't')
                .Replace('у', 'u').Replace('ў', 'u').Replace('ф', 'f').Replace('х', 'h').Replace("ц", "ts").Replace("ч", "ch").Replace("ш", "sh").Replace("щ", "sch").Replace("ь", String.Empty)
                .Replace("ъ", String.Empty).Replace("ю", "yu").Replace("я", "ya");

            // Upper case
            stringBuilder.Replace('А', 'A').Replace('Б', 'B').Replace('В', 'V').Replace('Г', 'G').Replace('Ґ', 'G').Replace('Д', 'D').Replace('Е', 'E').Replace('Э', 'E')
                .Replace('Ё', 'E').Replace('Є', 'E').Replace("Ж", "Zh").Replace('З', 'Z').Replace('І', 'I').Replace('Ї', 'I').Replace('И', 'I').Replace('Й', 'Y').Replace('Ы', 'Y')
                .Replace('К', 'K').Replace('Л', 'L').Replace('М', 'M').Replace('Н', 'N').Replace('О', 'O').Replace('П', 'P').Replace('Р', 'R').Replace('С', 'S').Replace('Т', 'T')
                .Replace('У', 'U').Replace('Ў', 'U').Replace('Ф', 'F').Replace('Х', 'H').Replace("Ц", "Ts").Replace("Ч", "Ch").Replace("Ш", "Sh").Replace("Щ", "Sch").Replace("Ь", String.Empty)
                .Replace("Ъ", String.Empty).Replace("Ю", "Yu").Replace("Я", "Ya");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Clear input string from predefined banned characters
        /// </summary>
        /// <param name="Value">Input string</param>
        /// <returns>Cleared string</returns>
        public static string Clear(this string Value)
        {
            return Value.Clear("\'", "\"", ":", "\\", "/", "?", "*", "<", ">", "|", "№", "«", "»", "\r", "\n");
        }

        /// <summary>
        /// Clear input string from Banned substrings
        /// </summary>
        /// <param name="Value">Input string</param>
        /// <param name="Banned"> Array of strings to Replace in input string</param>
        /// <returns>Cleared string</returns>
        public static string Clear(this string Value, params string[] Banned)
        {
            StringBuilder stringBuilder = new StringBuilder(Value);

            for (int i = 0; i < Banned.Length; i++)
            {
                stringBuilder.Replace(Banned[i], String.Empty);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Convert input string to Hex view (as in browser URL)
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string ToHex(this string Value)
        {
            string[] temp = new string[Value.Length * 3];
            for (int i = 0; i < Value.Length; i++)
            {
                temp[i] = "%" + ((int)Value[i]).ToString("X");
            }

            StringBuilder builder = new StringBuilder(temp.Length);
            for (int i = 0; i < temp.Length; i++)
            {
                builder.Append(temp[i]);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Select substring
        /// </summary>
        /// <param name="Value">Original string</param>
        /// <param name="Type">Type of selection</param>
        /// <param name="UpperCase">Specifies, if first letter should be UpperCase</param>
        /// <returns>Selected string</returns>
        public static string Select(this string Value, StringSelectType Type, bool UpperCase)
        {
            switch (Type)
            {
                case StringSelectType.Word:
                    {
                        return Value.SelectWord(UpperCase);
                    }

                case StringSelectType.Sentense:
                    {
                        return Value.SelectSentense(UpperCase);
                    }

                case StringSelectType.Line:
                    {
                        return Value.SelectLine(UpperCase);
                    }

                case StringSelectType.Phrase:
                    {
                        return Value.SelectPhrase(UpperCase);
                    }

                case StringSelectType.Paragraph:
                    {
                        return Value.SelectParagraph(UpperCase);
                    }
            }

            return Value.SelectWord(UpperCase);
        }

        internal static string SelectWord(this string Value)
        {
            if (!Value.Contains(" "))
            {
                return Value;
            }

            Random random = new Random();
            int startIndex = 0;
            int endIndex = 0;
            do
            {
                startIndex = Value.IndexOf(" ", random.Next(Value.Length)) + 1;
                endIndex = Value.IndexOf(" ", startIndex);
            } while (startIndex < 0 || endIndex < 0);

            return Value.Substring(startIndex, endIndex - startIndex);
        }

        internal static string SelectWord(this string Value, bool UpperCase)
        {
            return UpperCase ? ToUpper(Value.SelectWord(), StringToUpperType.FirstWord) : Value.SelectWord();
        }

        public static string ToUpper(this string Value, StringToUpperType Type)
        {
            switch (Type)
            {
                case StringToUpperType.FirstWord:
                    {
                        return Value.Length > 1
                                   ? Value.Substring(0, 1).ToUpper() + Value.Substring(1)
                                   : Value.ToUpper();
                    }

                case StringToUpperType.BigWords:
                    {
                        string[] words = Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i].Length > 2)
                            {
                                words[i] = words[i].ToUpper(StringToUpperType.FirstWord);
                            }
                        }

                        StringBuilder stringBuilder = new StringBuilder(Value.Length);

                        for (int i = 0; i < words.Length; i++)
                        {
                            stringBuilder.Append(words[i] + " ");
                        }

                        return stringBuilder.ToString().Trim();
                    }

                case StringToUpperType.AllWords:
                    {
                        string[] words = Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < words.Length; i++)
                        {
                            words[i] = words[i].ToUpper(StringToUpperType.FirstWord);
                        }

                        StringBuilder stringBuilder = new StringBuilder(Value.Length);

                        for (int i = 0; i < words.Length; i++)
                        {
                            stringBuilder.Append(words[i] + " ");
                        }

                        return stringBuilder.ToString().Trim();
                    }
            }

            return Value;
        }

        internal static string SelectSentense(this string Value)
        {
            if (!Value.Contains(".") && !Value.Contains("!") && !Value.Contains("?"))
            {
                return Value.SelectPhrase();
            }

            Random random = new Random();
            int startIndex = 0;
            int endIndex = 0;
            do
            {
                startIndex = Value.IndexOfAny(new char[] { '.', '!', '?' }, random.Next(Value.Length)) + 1;
                endIndex = Value.IndexOfAny(new char[] { '.', '!', '?' }, startIndex);
            } while (startIndex < 0 || endIndex < 0);

            return Value.Substring(startIndex, endIndex + 1 - startIndex);
        }

        internal static string SelectSentense(this string Value, bool UpperCase)
        {
            return UpperCase ? ToUpper(Value.SelectSentense(), StringToUpperType.FirstWord) : Value.SelectSentense();
        }

        internal static string SelectLine(this string Value)
        {
            if (!Value.Contains("\n"))
            {
                return Value.SelectSentense();
            }

            Random random = new Random();
            int startIndex = 0;
            int endIndex = 0;
            do
            {
                startIndex = Value.IndexOf("\n", random.Next(Value.Length)) + 1;
                endIndex = Value.IndexOf("\n", startIndex);
            } while (startIndex < 0 || endIndex < 0);

            return Value.Substring(startIndex, endIndex - startIndex);
        }

        internal static string SelectLine(this string Value, bool UpperCase)
        {
            return UpperCase ? ToUpper(Value.SelectLine(), StringToUpperType.FirstWord) : Value.SelectLine();
        }

        internal static string SelectPhrase(this string Value)
        {
            Random random = new Random();
            int startIndex = 0;
            int endIndex = 0;
            do
            {
                startIndex = Value.IndexOf(" ", random.Next(Value.Length)) + 1;
                endIndex = Value.IndexOf(" ", startIndex + random.Next(80, 130));
            } while (startIndex < 0 || endIndex < 0);

            return Value.Substring(startIndex, endIndex - startIndex);
        }

        internal static string SelectPhrase(this string Value, bool UpperCase)
        {
            return UpperCase ? ToUpper(Value.SelectPhrase(), StringToUpperType.FirstWord) : Value.SelectPhrase();
        }

        internal static string SelectParagraph(this string Value)
        {
            if (!Value.Contains("\n"))
            {
                return Value.SelectSentense();
            }

            if (!Value.Contains("\r\n\r\n"))
            {
                return Value.SelectLine();
            }

            Random random = new Random();
            int startIndex = 0;
            int endIndex = 0;
            do
            {
                startIndex = Value.IndexOf("\n", random.Next(Value.Length)) + 1;
                endIndex = Value.IndexOf("\n", startIndex);
            } while (startIndex < 0 || endIndex < 0);

            return Value.Substring(startIndex, endIndex - startIndex);
        }

        internal static string SelectParagraph(this string Value, bool UpperCase)
        {
            return UpperCase ? ToUpper(Value.SelectParagraph(), StringToUpperType.FirstWord) : Value.SelectParagraph();
        }

        public static string[] Split(this string Value, StringSplitType Type)
        {
            return Value.Split(Type, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] Split(this string Value, StringSplitType Type, StringSplitOptions Options)
        {
            switch (Type)
            {
                case StringSplitType.Word:
                    {
                        return Value.SplitWords(Options);
                    }

                case StringSplitType.Fragment:
                    {
                        return Value.SplitFragment(Options);
                    }

                case StringSplitType.Sentence:
                    {
                        return Value.SplitSentence(Options);
                    }

                case StringSplitType.Line:
                    {
                        return Value.SplitLine(Options);
                    }

                case StringSplitType.Block:
                    {
                        return Value.SplitBlock(Options);
                    }
            }

            return Value.SplitWords(Options);
        }

        internal static string[] SplitWords(this string Value, StringSplitOptions Options)
        {
            return Value.Split(new char[] { ' ' }, Options);
        }

        internal static string[] SplitFragment(this string Value, StringSplitOptions Options)
        {
            return Value.Split(new string[] { ":", ";", ",", ".", "?", "!" }, Options);
        }

        internal static string[] SplitSentence(this string Value, StringSplitOptions Options)
        {
            return Value.Split(new string[] { "...", ".", "?", "!" }, Options);
        }

        internal static string[] SplitLine(this string Value, StringSplitOptions Options)
        {
            return Value.Split(new string[] { "\r\n", "\n", "\r" }, Options);
        }

        internal static string[] SplitBlock(this string Value, StringSplitOptions Options)
        {
            string[] result = Value.Split(new string[] {"-------"}, Options);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = result[i].Trim('-');
            }

            return result;
        }

        /// <summary>
        /// Open up string. For example input sting: [A|B|C]. As output will be selected one of letters.
        /// </summary>
        /// <param name="Value">Input string</param>
        /// <param name="OpenString">Open string</param>
        /// <param name="CloseString">Close string</param>
        /// <param name="SeparatorStrings">Array of separator strings</param>
        /// <returns>Processed string</returns>
        public static string OpenUp(this string Value, string OpenString, string CloseString, params string[] SeparatorStrings)
        {
            if (OpenString == CloseString || SeparatorStrings.Length == 0)
            {
                return Value;
            }

            if (!Value.Contains(OpenString) && !Value.Contains(CloseString))
            {
                return Value.Replace(OpenString, String.Empty).Replace(CloseString, String.Empty);
            }

            Random random = new Random(Environment.TickCount);

            do
            {
                int endIndex = Value.IndexOf(CloseString);
                int startIndex = Value.LastIndexOf(OpenString, 0, endIndex);

                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }

                string[] parts =
                    Value.Substring(startIndex,
                                          (Value.Length < endIndex + 1)
                                              ? (endIndex + 1 - startIndex) : (Value.Length - startIndex))
                                              .Replace(OpenString, String.Empty).Replace(CloseString, String.Empty)
                                              .Split(SeparatorStrings, StringSplitOptions.RemoveEmptyEntries);

                Value = Value.Substring(0, startIndex) +
                              ((parts.Length > 0) ? parts[random.Next(parts.Length)] : String.Empty) +
                              ((Value.Length < endIndex + 1) ? Value.Substring(endIndex + 1) : String.Empty);

            } while (Value.Contains(OpenString) && Value.Contains(CloseString));

            return Value.Replace(OpenString, String.Empty).Replace(CloseString, String.Empty);
        }

        public static string ReorderWords(this string Value, StringReorderType Type)
        {
            switch (Type)
            {
                case StringReorderType.Random:
                    {
                        return Value.ReorderWordsRandom();
                    }

                case StringReorderType.Reverse:
                    {
                        return Value.ReorderWordsReverse();
                    }
            }

            return Value.ReorderWordsRandom();
        }

        internal static string ReorderWordsRandom(this string Value)
        {
            List<string> items = Value.Split(StringSplitType.Word).ToList();

            if (items.Count <= 1)
            {
                return Value;
            }

            Random random = new Random();

            for (int i = 0; i < items.Count; i++)
            {
                items.Swap(i, random.Next(items.Count));
            }

            return items.AsString();
        }

        internal static string ReorderWordsReverse(this string Value)
        {
            List<string> items = Value.Split(StringSplitType.Word).ToList();

            if (items.Count <= 1)
            {
                return Value;
            }

            for (int i = 0; i < items.Count / 2; i++)
            {
                items.Swap(i, items.Count - 1 - i);
            }

            return items.AsString();
        }

        /// <summary>
        /// Returns a value indicating whether string contains all or any of searched items
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Type"></param>
        /// <param name="Items"></param>
        /// <returns></returns>
        public static bool Contains(this string Value, StringContainsType Type, params string[] Items)
        {
            return Value.Contains(Type, false, Items);
        }

        /// <summary>
        /// Returns a value indicating whether string contains all or any of searched items
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Type"></param>
        /// <param name="IgnoreCase"></param>
        /// <param name="Items"></param>
        /// <returns></returns>
        public static bool Contains(this string Value, StringContainsType Type, bool IgnoreCase, params string[] Items)
        {
            switch (Type)
            {
                case StringContainsType.All:
                    {
                        for (int i = 0; i < Items.Length; i++)
                        {
                            if (!(IgnoreCase ? Value.ToLower().Contains(Items[i].ToLower()) : Value.Contains(Items[i])))
                            {
                                return false;
                            }
                        }

                        return true;
                    }

                case StringContainsType.Any:
                    {
                        for (int i = 0; i < Items.Length; i++)
                        {
                            if (IgnoreCase ? Value.ToLower().Contains(Items[i].ToLower()) : Value.Contains(Items[i]))
                            {
                                return true;
                            }
                        }

                        return false;
                    }
            }

            return false;
        }

        /// <summary>
        /// Clear input string from HTML tags
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string ClearHTML(this string Value)
        {
            // Удаление стилей и скриптов
            while (Value.Contains("<style") && Value.Contains("</style>"))
            {
                Value = Value.Remove(Value.IndexOf("<style"), Value.IndexOf("</style>", Value.IndexOf("<style")) + 8 - Value.IndexOf("<style"));
            }

            while (Value.Contains("<script") && Value.Contains("</script>"))
            {
                Value = Value.Remove(Value.IndexOf("<script"), Value.IndexOf("</script>", Value.IndexOf("<script")) + 9 - Value.IndexOf("<script"));
            }

            while (Value.Contains("<STYLE") && Value.Contains("</STYLE>"))
            {
                Value = Value.Remove(Value.IndexOf("<STYLE"), Value.IndexOf("</STYLE>", Value.IndexOf("<STYLE")) + 8 - Value.IndexOf("<STYLE"));
            }

            while (Value.Contains("<SCRIPT") && Value.Contains("</SCRIPT>"))
            {
                Value = Value.Remove(Value.IndexOf("<SCRIPT"), Value.IndexOf("</SCRIPT>", Value.IndexOf("<SCRIPT")) + 9 - Value.IndexOf("<SCRIPT"));
            }

            Regex myReg = new Regex("<[\\/\\!]*?[^<>]*?>", RegexOptions.IgnoreCase);
            Value = myReg.Replace(Value, String.Empty);

            // уборка лишних пробелов
            myReg = new Regex("\\x20+");
            Value = myReg.Replace(Value, " ");

            // уборка функций
            while (Value.Contains("function"))
            {
                try
                {
                    Value = Value.Remove(Value.IndexOf("function"), Value.IndexOf("}", Value.IndexOf("function")) + 1 - Value.IndexOf("function"));
                }
                catch (Exception)
                {
                    break;
                }
            }

            // уборка табов и переходов на новую строку
            while (Value.Contains("\t\t"))
            {
                Value = Value.Replace("\t\t", "\t");
            }

            while (Value.Contains("\t\r\n"))
            {
                Value = Value.Replace("\t\r\n", "\r\n");
            }

            while (Value.Contains("\r\n\t"))
            {
                Value = Value.Replace("\r\n\t", "\r\n");
            }

            while (Value.Contains("\r\n\r\n"))
            {
                Value = Value.Replace("\r\n\r\n", "\r\n");
            }

            // уборка комментариев
            while (Value.Contains("<!--"))
            {
                try
                {
                    Value = Value.Remove(Value.IndexOf("<!--"), Value.IndexOf("-->", Value.IndexOf("<!--")) + 3 - Value.IndexOf("<!--"));
                }
                catch (Exception)
                {
                    break;
                }
            }

            while (Value.Contains("@import url"))
            {
                try
                {
                    Value = Value.Remove(Value.IndexOf("@import url"), Value.IndexOf(";", Value.IndexOf("@import url")) + 1 - Value.IndexOf("@import url"));
                }
                catch (Exception)
                {
                    break;
                }
            }

            while (Value.Contains("&nbsp;"))
            {
                Value = Value.Replace("&nbsp;", " ");
            }

            while (Value.Contains(" \r\n"))
            {
                Value = Value.Replace(" \r\n", "\r\n");
            }

            // уборка табов и переходов на новую строку
            while (Value.Contains("\t\r\n"))
            {
                Value = Value.Replace("\t\r\n", "\r\n");
            }

            while (Value.Contains("\t\t"))
            {
                Value = Value.Replace("\t\t", "\t");
            }


            while (Value.Contains("\r\n\r\n"))
            {
                Value = Value.Replace("\r\n\r\n", "\r\n");
            }

            while (Value.Contains("//"))
            {
                Value = Value.Replace("//", String.Empty);
            }

            // уборка лишних пробелов
            myReg = new Regex("\\x20+");
            Value = myReg.Replace(Value, " ");

            return Value;
        }

        public static string Cut(this string Value, int Length)
        {
            if (Value.Length < Length)
            {
                return Value;
            }

            return Value.Substring(0, Length);
        }

        public static int LastIndexOf(this string Content, string TokenRegExTemplate, string TokenStartValue, int LastIndex)
        {
            int firstIndex = Content.IndexOf(TokenStartValue);
            int actualIndex = 0;

            while (true)
            {
                if (LastIndex < firstIndex || firstIndex < 0)
                {
                    break;
                }

                string tempString = Content.Substring(firstIndex + TokenStartValue.Length, LastIndex - firstIndex - TokenStartValue.Length);
                if (!Regex.IsMatch(tempString, TokenRegExTemplate, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline))
                {
                    if (actualIndex <= firstIndex && firstIndex < LastIndex)
                    {
                        actualIndex = firstIndex;
                    }

                    break;
                }

                firstIndex = Content.IndexOf(TokenStartValue, firstIndex + TokenStartValue.Length);
            }

            return actualIndex;
        }

        public static int LastIndexOf(this string Content, string TokenRegExTemplate, string TokenStartValue, string TokenEndValue)
        {
            return Content.LastIndexOf(TokenRegExTemplate, TokenStartValue, Content.IndexOf(TokenEndValue));
        }

        public static string ReplaceOne(this string Content, string OldValue, string NewValue)
        {
            int index = Content.IndexOf(OldValue);

            if (index < 0)
            {
                return Content;
            }

            return Content.Remove(index, OldValue.Length).Insert(index, NewValue);
        }
    }
}
