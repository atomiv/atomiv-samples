using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class InputReader : IReader
    {
        public InputReader(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; }

        public string Text { get; }

        public Document Read()
        {
            return new Document(Name, Text);
        }
    }
}
