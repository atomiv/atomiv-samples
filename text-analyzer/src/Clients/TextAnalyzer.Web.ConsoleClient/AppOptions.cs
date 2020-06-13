using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class AppOptions
    {
        public const string Key = "App";

        public string RestApi { get; set; }

        public string ReaderFactory { get; set; }
    }
}
