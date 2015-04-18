using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Umax.Classes.Enums;
using Umax.Classes.Helpers;
using Umax.Classes.XML;
using Umax.Interfaces.Compatibility.Tokens;
using Umax.Interfaces.Enums;
using Umax.Interfaces.Images;
using Umax.Plugins.Images.Enums;
using IO = System.IO;

namespace Umax.Plugins.Images.Common
{
    public abstract class ImageMaker : IImageMaker, ITokensRegexCompatible
    {
        public ImageMaker()
        {
            this.Random = new Random();

            this.Images = new List<string>();

            this.State = MakerStateType.Uninitialized;
        }

        public abstract string Name { get; }

        /// <summary>
        /// Gets category
        /// </summary>
        public virtual string Category
        {
            get { return "Standard"; }
        }

        /// <summary>
        /// Gets control name
        /// </summary>
        public abstract string ControlName { get; }

        /// <summary>
        /// Gets GUI Name
        /// </summary>
        public abstract string GUIName { get; }

        /// <summary>
        /// Gets array of tokens
        /// </summary>
        public virtual string[] Tokens { get { return new string[] { "[IMAGE]" }; } }

        /// <summary>
        /// Gets array of regex tokens
        /// </summary>
        public virtual string[] RegexTokens { get { return new string[] { @"\[Image\]" }; } }

        /// <summary>
        /// Gets or sets settings
        /// </summary>
        public virtual IImageSettings Settings { get; set; }

        /// <summary>
        /// Gets or sets random
        /// </summary>
        protected virtual Random Random { get; set; }

        /// <summary>
        /// Gets or sets validate state
        /// </summary>
        public MakerStateType State { get; set; }

        /// <summary>
        /// Gets or sets array of filenames from file
        /// </summary>
        protected virtual string[] ExternalImageNames { get; set; }

        /// <summary>
        /// Gets or sets array of external images
        /// </summary>
        protected virtual string[] ExternalImages { get; set; }

        /// <summary>
        /// Gets or sets list of images, that has been used
        /// </summary>
        protected virtual List<string> Images { get; set; }

        /// <summary>
        /// Gets or sets maximum number of images
        /// </summary>
        protected virtual int MaximumCount { get; set; }

        /// <summary>
        /// Gets or sets current number of images
        /// </summary>
        protected virtual int CurrentCount
        {
            get
            {
                return this.Images.Count;
            }
        }

        /// <summary>
        /// Copying/Generating image
        /// </summary>
        /// <param name="Path">Path to the site directory</param>
        /// <param name="Content">Content to make replaces in</param>
        /// <param name="Items">List of items</param>
        /// <returns>Content with replaced tokens</returns>
        public string Invoke(string Path, string Content, List<string> Items)
        {
            for (int i = 0; i < this.RegexTokens.Length; i++)
            {
                while (Regex.IsMatch(Content, this.RegexTokens[i], RegexOptions.Compiled))
                {
                    string token = Regex.Match(Content, this.RegexTokens[i], RegexOptions.Compiled).Value;
                    string image = this.MakeImage(Path, Items);

                    // Replace
                    int index = Content.IndexOf(token);
                    Content = Content.Remove(index, token.Length);
                    Content = Content.Insert(index, image);
                }
            }

            return Content;
        }

        protected abstract string MakeImage(string Path, List<string> Items);

        /// <summary>
        /// Load settings from file
        /// </summary>
        /// <param name="ImagePath">File path</param>
        public virtual void Load(string ImagePath)
        {
            try
            {
                this.Settings = (IImageSettings)CustomXmlDeserializer.Deserialize(IO.File.ReadAllText(IO.Path.Combine(ImagePath, "images.xml"), Encoding.Default), 1);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Save settings to file
        /// </summary>
        /// <param name="ImagePath">File path</param>
        public virtual void Save(string ImagePath)
        {
            try
            {
                CustomXmlSerializer.Serialize(this.Settings, 1, this.Settings.Name).Save(IO.Path.Combine(ImagePath, "images.xml"));
            }
            catch (Exception) { }
        }

        public virtual void Initialize()
        {
            try
            {
                this.State = this.Validate();
            }
            catch (Exception ex)
            {
                this.State = MakerStateType.Invalid;
                throw ex;
            }
        }

        protected abstract MakerStateType Validate();

        public abstract object NewInstance();

        public virtual void Dispose()
        {
            this.Settings = null;
        }

        /// <summary>
        /// Generates new filename
        /// </summary>
        /// <param name="FileName">Filename, ie image.jpg.</param>
        /// <param name="Keywords">List of keywords</param>
        /// <param name="Type">Type of rename</param>
        /// <returns>New filename</returns>
        protected virtual string MakeFileName(string FileName, List<string> Keywords, RenameType Type)
        {
            return MakeFileName(FileName, Keywords[new Random().Next(Keywords.Count)], Type);
        }

        /// <summary>
        /// Generates new filename
        /// </summary>
        /// <param name="FileName">Filename, ie image.jpg.</param>
        /// <param name="Keyword">Keyword</param>
        /// <param name="Type">Type of rename</param>
        /// <returns>New filename</returns>
        protected virtual string MakeFileName(string FileName, string Keyword, RenameType Type)
        {
            switch (Type)
            {
                // Random
                case RenameType.Random:
                    {
                        return (StringHelper.MakeRandom(2, 4, StringCharactersType.UpperCase) +
                                StringHelper.MakeRandom(2, 5, StringCharactersType.LowerCase) +
                                StringHelper.MakeRandom(2, 3, StringCharactersType.Numbers)).Mix() +
                               (FileName.Contains(".") ? FileName.Substring(FileName.LastIndexOf(".")) : string.Empty);
                    }

                // Name
                case RenameType.Name:
                    {
                        return FileName;
                    }

                // Name -> En
                case RenameType.NameToEn:
                    {
                        return FileName.Translite();
                    }

                // Keyword
                case RenameType.Keyword:
                    {
                        return Keyword.Clear() +
                               (FileName.Contains(".") ? FileName.Substring(FileName.LastIndexOf(".")) : string.Empty);
                    }

                // Keyword -> En
                case RenameType.KeywordToEn:
                    {
                        return Keyword.Translite().Clear() +
                               (FileName.Contains(".") ? FileName.Substring(FileName.LastIndexOf(".")) : string.Empty);
                    }

                // FromFile
                case RenameType.FromFile:
                    {
                        return this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Clear() +
                               (FileName.Contains(".") ? FileName.Substring(FileName.LastIndexOf(".")) : string.Empty);
                    }

                // FromFile -> En
                case RenameType.FromFileToEn:
                    {
                        return this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Translite().Clear() +
                               (FileName.Contains(".") ? FileName.Substring(FileName.LastIndexOf(".")) : string.Empty);
                    }
            }

            return FileName;
        }

        protected virtual string MakeFileName(List<string> Keywords, NameType Type)
        {
            switch (Type)
            {
                case NameType.Random:
                    {
                        return (StringHelper.MakeRandom(2, 4, StringCharactersType.UpperCase) +
                                StringHelper.MakeRandom(2, 5, StringCharactersType.LowerCase) +
                                StringHelper.MakeRandom(2, 3, StringCharactersType.Numbers)).Mix();
                    }

                case NameType.Keyword:
                    {
                        return Keywords[this.Random.Next(Keywords.Count)].Clear();
                    }

                case NameType.KeywordToEn:
                    {
                        return Keywords[this.Random.Next(Keywords.Count)].Translite().Clear();
                    }

                case NameType.FromFile:
                    {
                        return this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Clear();
                    }

                case NameType.FromFileToEn:
                    {
                        return
                            this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Translite().Clear();
                    }
            }

            return string.Empty;
        }

        protected virtual string MakeFileName(string Keyword, NameType Type)
        {
            switch (Type)
            {
                case NameType.Random:
                    {
                        return (StringHelper.MakeRandom(2, 4, StringCharactersType.UpperCase) +
                                StringHelper.MakeRandom(2, 5, StringCharactersType.LowerCase) +
                                StringHelper.MakeRandom(2, 3, StringCharactersType.Numbers)).Mix();
                    }

                case NameType.Keyword:
                    {
                        return Keyword.Replace("\r\n", "-").Clear();
                    }

                case NameType.KeywordToEn:
                    {
                        return Keyword.Replace("\r\n", "-").Translite().Clear();
                    }

                case NameType.FromFile:
                    {
                        return this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Clear();
                    }

                case NameType.FromFileToEn:
                    {
                        return
                            this.ExternalImageNames[this.Random.Next(this.ExternalImageNames.Length)].Translite().Clear();
                    }
            }

            return string.Empty;
        }
    }
}
