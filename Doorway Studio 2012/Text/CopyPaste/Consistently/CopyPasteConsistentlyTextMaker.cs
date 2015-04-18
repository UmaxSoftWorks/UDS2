﻿using System;
using System.Collections.Generic;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Plugins.Text.Common;
using Umax.Plugins.Text.Enums;

namespace Umax.Plugins.Text.CopyPaste.Consistently
{
    public class CopyPasteConsistentlyTextMaker : TextMaker
    {
        public CopyPasteConsistentlyTextMaker()
        {
            this.Index = 0;
            this.Settings = new CopyPasteConsistentlyTextSettings();
        }

        public override string Name
        {
            get { return "CopyPasteConsistentlyTextMaker"; }
        }

        public override string Category
        {
            get { return "Standard"; }
        }

        public override string ControlName
        {
            get { return "CopyPasteConsistentlyTextControl"; }
        }

        public override string GUIName
        {
            get { return "Copy/Paste: Consistently"; }
        }

        /// <summary>
        /// Gets or sets Working set of text
        /// </summary>
        protected string[] Fragments { get; set; }

        /// <summary>
        /// Gets or sets current index of the word in text
        /// </summary>
        protected int Index { get; set; }

        public override object NewInstance()
        {
            return new CopyPasteConsistentlyTextMaker();
        }

        public override string Invoke(string Content, List<string> Keywords)
        {
            return string.Empty;
        }

        protected override void InitializeContent()
        {
            // Work on brackets
            base.InitializeContent();

            this.Fragments = this.Content.ToLower().Split(StringSplitType.Word, StringSplitOptions.RemoveEmptyEntries);
        }

        protected override List<string> MakeText(TokenType Type)
        {
            int length = this.MakeTextLength(Type);

            List<string> text = new List<string>(length);

            while (text.Count < length)
            {
                text.Add(this.Fragments[this.Index]);

                this.Index++;
                if (this.Fragments.Length < this.Index)
                {
                    this.Index = 0;
                }
            }

            return text;
        }
    }
}
