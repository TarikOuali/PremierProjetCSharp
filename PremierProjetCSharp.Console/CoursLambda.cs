using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PremierProjetCSharp.ConsoleApp
{
    public class CoursLambda
    {
        public CoursLambda()
        {
            Action f1 = () =>
            {
                Console.WriteLine("Hello");
            };
            Action<string> f2 = (string name) =>
            {
                Console.WriteLine($"Hello {name}");
            };
            Func<int> f3 = () =>
            {
                Console.WriteLine("Hello");
                return 0;
            };
            Func<string, int> f4 = (string name) =>
            {
                Console.WriteLine($"Hello {name}");
                return name.Length;
            };

            f1.Invoke();
            f2.Invoke("test");


            //var x1 = GetSum<short>(b: 5, a: 6);
            //var x2 = GetSum(b: 5.2, a: 6.4);

        }

        //private int GetSum(int a, int b)
        //{
        //    return a + b;
        //}
        //private double GetSum(double a, double b)
        //{
        //    return a + b;
        //}

        //private T GetSum<T>(T a, T b) //where T: struct
        //{
        //    switch (typeof(T))
        //    {
        //        case var e when e is byte:
        //            return ((byte)a) + (byte)b;
        //        case var tnumeric when tnumeric is 
        //        default:
        //            break;
        //    }
            
        //}


        private void SayHello()
        {
            Console.WriteLine("Hello");
        }
        private void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        private int SayHelloBis()
        {
            Console.WriteLine("Hello");
            return 0;
        }
        private int SayHelloBis(string name)
        {
            Console.WriteLine($"Hello {name}");
            return name.Length;
        }




    }
}
