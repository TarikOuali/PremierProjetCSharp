using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetCSharp.ConsoleApp
{
    public enum Genres
    {
        Male = 1,
        Female = 2,
        Other = 4
    }
    public class MaClasse : Object //implicitement de type object (reference)
    {
        //constructeur
        private MaClasse()
        {
            GetCaptainAge(true);
        }

        private static object _obj = new object();
        static MaClasse _cls = default;
        public static MaClasse GetInstance()
        {
            lock (_obj)
            {
                if (_cls == null)
                    _cls = new MaClasse();
            }

            return _cls;
        }




        //Les membres de la classe :
        //variables
        public string Message = string.Empty; //eq de ""
        //constantes
        const int FTP_PORT = 21;
        //propriétés
        public bool IsCool { get; private set; }
        public int MyProperty { get; set; }
        private int myVar;


        public int Property2
        {
            get
            {
                return myVar;
            }
            set
            {
                if (myVar == value)
                    return;
                myVar = value;
                if (CaptainAgeChanged != null)
                {
                    CaptainAgeChanged.Invoke(this, myVar);
                }
            }
        }

        //méthodes (ou fonctions)
        public void DoWork()
        {
            //instructions
        }
        private int GetCaptainAge()
        {
            Genres g = Genres.Other;
            switch (g)
            {
                case Genres.Male:
                    //
                    //
                    break;
                case Genres.Female:
                    //
                    //
                    break;
                case Genres.Other:
                default:
                    //
                    //
                    break;
            }

            switch (Property2)
            {
                case 0:
                    break;
                case var x when x > 1 && x < 5:
                    
                    break;
                case var y when y.Equals(5):
                    break;
                default:
                    break;
            }



            return Property2;
        }

        private int GetCaptainAge(bool ok) { return 0; }
        private int GetCaptainAge(bool ok, int test) { return 0; }


        //evenements
        public event EventHandler<int> CaptainAgeChanged;
    }
}
