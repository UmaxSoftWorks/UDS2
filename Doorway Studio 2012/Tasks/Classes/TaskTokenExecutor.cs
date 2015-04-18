using System.Collections.Generic;
using System.Linq;
using Umax.Classes.Containers;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Images;
using Umax.Interfaces.Text;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tasks.Classes
{
    public class TaskTokenExecutor
    {
        protected virtual ContentContainer Content { get; set; }

        public TaskTokenExecutor(ContentContainer Content)
        {
            this.FileTokens = new List<FileTokenExecutor>();
            this.Content = Content;
        }

        public virtual ITokenContainer Tokens { get; set; }
        public virtual List<FileTokenExecutor> FileTokens { get; set; }

        public virtual void Invoke(IPage Page)
        {
            // Tokens
            Page.Content = this.ReplaceComplexTokens(Page);

            // Internal
            Page.Content = this.ReplaceComplexInternalTokens(Page);

            // File
            Page.Content = this.ReplaceFileTokens(Page.Content);

            // Text
            Page.Content = this.ReplaceTextTokens(Page.Content, Page.Keywords);

            // Images
            Page.Content = this.ImageMaker.Invoke(this.Content.Path, Page.Content, Page.Keywords);

            // Tokens
            Page.Content = this.Invoke(Page.Content);
        }

        public virtual string Invoke(string Content)
        {
            // Tokens
            Content = this.ReplaceSimpleTokens(Content);

            // Internal
            Content = this.ReplaceSimpleInternalTokens(Content);

            // Text
            Content = this.ReplaceTextTokens(Content, new List<string>());

            return Content;
        }

        public ITextMaker TextMaker { get; set; }

        public IImageMaker ImageMaker { get; set; }

        protected virtual string ReplaceTextTokens(string Content, List<string> Items)
        {
            return this.TextMaker.Invoke(Content, Items);
        }

        protected virtual string ReplaceComplexTokens(IPage Page)
        {
            string content = string.Empty;

            List<IComplexToken> items = (from IToken item in this.Tokens.Items.ToList()
                                         where item is IComplexToken
                                         orderby item.Priority
                                         select item as IComplexToken).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                content = items[i].Invoke(Page, this.Content);
            }

            return content;
        }

        protected virtual string ReplaceSimpleTokens(string Content)
        {
            List<ISimpleToken> items = (from IToken item in this.Tokens.Items.ToList()
                                        where item is ISimpleToken
                                        orderby item.Priority
                                        select item as ISimpleToken).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                Content = items[i].Invoke(Content);
            }

            return Content;
        }

        protected virtual string ReplaceFileTokens(string Content)
        {
            for (int i = 0; i < this.FileTokens.Count; i++)
            {
                Content = this.FileTokens[i].Invoke(this.Content.Index, Content);
            }

            return Content;
        }

        protected virtual string ReplaceComplexInternalTokens(IPage Page)
        {
            string content = string.Empty;

            List<IComplexToken> items = (from IToken item in InternalTokens.Instance.Items.ToList()
                                         where item is IComplexToken
                                         orderby item.Priority
                                         select item as IComplexToken).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                content = items[i].Invoke(Page, this.Content);
            }

            return content;
        }

        protected virtual string ReplaceSimpleInternalTokens(string Content)
        {
            List<ISimpleToken> items = (from IToken item in InternalTokens.Instance.Items.ToList()
                                        where item is ISimpleToken
                                        orderby item.Priority
                                        select item as ISimpleToken).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                Content = items[i].Invoke(Content);
            }

            return Content;
        }
    }
}
