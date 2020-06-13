using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class DatabaseReader : IReader
    {
        private const string DefaultDocumentTableName = "Documents";
        private const string DefaultDocumentNameField = "Name";
        private const string DefaultDocumentTextField = "Text";

        public DatabaseReader(string connectionString, 
            string documentName,
            string documentTableName = DefaultDocumentTableName, 
            string documentNameField = DefaultDocumentNameField, 
            string documentTextField = DefaultDocumentTextField)
        {
            ConnectionString = connectionString;
            DocumentName = documentName;
            DocumentTableName = documentTableName;
            DocumentNameField = documentNameField;
            DocumentTextField = documentTextField;
        }

        public string ConnectionString { get; }

        public string DocumentName { get; }

        public string DocumentTableName { get; }

        public string DocumentNameField { get; }

        public string DocumentTextField { get; }

        public Document Read()
        {
            // TODO: Create DB connection read, close DB connection

            throw new NotImplementedException();
        }
    }
}
