using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient
{
    public interface IReader
    {
        Document Read();
    }
}
