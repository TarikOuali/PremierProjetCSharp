using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace PremierProjetCSharp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls = MaClasse.GetInstance();
            cls.CaptainAgeChanged += Cls_CaptainAgeChanged;
            
            
            cls.CaptainAgeChanged += Cls_CaptainAgeChanged2;

            Console.WriteLine("Quel est votre age ?");
            var entry = Console.ReadLine();



            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
                Delimiter = ";",
            };

            //var reader = new StreamReader("path\\to\\file.csv");
            //var csv = new CsvReader(reader, config);

            //var records = csv.GetRecords<Livre>();

            //csv.Dispose();
            //reader.Dispose();

            //le nom du fichier
            var filename = "livres.csv";
            //dossier de travail
            var workDir = AppDomain.CurrentDomain.BaseDirectory;
            //dossier où se trouve le fichier
            var filePath = Path.Combine(workDir, "csv", filename);

            IEnumerable<Livre>? livres = default;
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                livres = csv.GetRecords<Livre>();//.ToList();

                if (livres != null && livres.Count() > 0)
                {
                    foreach (var livre in livres)
                    {
                        Console.WriteLine($"Titre: {livre.Titre}, Auteur: {livre.Auteur}, Année: {livre.Annee}, Style: {livre.Style}");
                    }
                }
                else
                {
                    Console.WriteLine($"Pas de livres dans le fichier '{filePath}'");
                }
            }

        }

        private static void Cls_CaptainAgeChanged(object? sender, int e)
        {
            System.Console.WriteLine($"Captain age changed : {e} years old");
        }
        private static void Cls_CaptainAgeChanged2(object? sender, int e)
        {
            System.Console.WriteLine($"call back 2 : {e} years old");
        }
    }
}

