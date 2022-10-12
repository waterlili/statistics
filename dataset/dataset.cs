using FileHelpers;
using System;
namespace parse_csv
{
    [DelimitedRecord(",")]
    public class Record
    {
        public string Name;

        public string Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fileHelperEngine = new FileHelperEngine<Record>();
            var records = fileHelperEngine.ReadFile(@"/home/niloufar/Documents/statistics2/dataset/music.csv");

            foreach (var record in records)
            {
                Console.WriteLine(record.Name);
                Console.WriteLine(record.Age);
            }
        }
    }
}