using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetCSharp.ConsoleApp
{
    public interface IOeuvre
    {
        string Name { get; set; }
        int GetParagraphsCount();
    }

    public abstract class AbstractOeuvre : IOeuvre
    {
        //membre abstrait, contraire de concret, pas de code ni de compilation possible
        public abstract string Name { get; set; }       

        //code concret, donc compilé
        //virtual donne la possibilité aux classes enfants de redéfinir
        //ou réécrire cette méthode
        public virtual int GetParagraphsCount()
        {
            foreach (var item in Enumerable.Range(0,5))
            {
                Console.WriteLine(item);
            }
            return 42;
        }
    }

    public interface IListenable
    {
        void Listen();
    }
    public interface IReadable
    {
        void Read();
    }

    public class Podcast : AbstractOeuvre, IListenable
    {
        public override string Name { get; set; }

        public void Listen()
        {
            //throw new NotImplementedException();
        }

    }




    public class Livre : AbstractOeuvre, IReadable, IDisposable
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
        public override string Name { get; set; }

        public void Dispose()
        {
            //actions pour libérer les ressources de l'instance
        }

        public void Read()
        {
            //throw new NotImplementedException();
        }

        public override int GetParagraphsCount()
        {
            return 0;//throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
