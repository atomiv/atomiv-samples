using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class Document
    {
        public Document(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; }

        public string Text { get; }
    }
}
