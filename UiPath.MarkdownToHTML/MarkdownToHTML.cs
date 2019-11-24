using Markdig;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiPath.MarkdownToHTML
{
    public class MarkdownToHTML : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> InputMarkdownString { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<string> OutputHTMLString { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var inputMarkdown = InputMarkdownString.Get(context);
            string result = Markdown.ToHtml(inputMarkdown);
            OutputHTMLString.Set(context, result);
        }
    }
}
