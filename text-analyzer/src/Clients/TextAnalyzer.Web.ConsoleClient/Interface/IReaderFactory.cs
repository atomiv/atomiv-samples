using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Interface
{
    public interface IReaderFactory
    {
        IReader Create(ReaderType readerType);
    }
}
