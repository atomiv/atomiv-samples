using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            var parameters = new
            {
                Name = DocumentName,
            };

            using(var connection = new SqlConnection(ConnectionString))
            {
                var query = $"SELECT {DocumentTextField} FROM {DocumentTableName}" +
                    $"WHERE {DocumentNameField} = @DocumentName";

                var documentRecords = connection
                    .Query<DocumentRecord>(query, parameters)
                    .ToList();

                return documentRecords.Select(GetDocument).FirstOrDefault();
            }
        }

        private Document GetDocument(DocumentRecord record)
        {
            return new Document(record.Name, record.Text);
        }

        private class DocumentRecord
        {
            public string Name { get; set; }

            public string Text { get; set; }
        }
    }
}
