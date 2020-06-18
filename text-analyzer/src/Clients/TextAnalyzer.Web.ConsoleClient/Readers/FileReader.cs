using System.IO;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class FileReader : IReader
    {
        public FileReader(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; }

        public Document Read()
        {
            var name = Path.GetFileNameWithoutExtension(FilePath);
            var text = File.ReadAllText(FilePath);

            return new Document(name, text);
        }
    }
}
