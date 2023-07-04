using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetCSharp.ConsoleApp
{
    public interface IListenable
    {
        void Listen();
    }
    public interface IReadable
    {
        void Read();
    }



    public class Livre: IReadable, IDisposable
    {
        [Name("titre")]
        public string Titre { get; set; }

        [Name("année d'édition")]
        public int Annee { get; set; }

        private string _auteur;

        [Name("auteur")]
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        [Name("style littéraire")]
        public string Style { get; set; }

        public void Dispose()
        {
            //actions pour libérer les ressources de l'instance
        }

        public void Read()
        {
            //throw new NotImplementedException();
        }
    }
}
