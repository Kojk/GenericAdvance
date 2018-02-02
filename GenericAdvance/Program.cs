using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("pred {0},{1}", a, b);
            Swapper.Swap<int>(ref a,ref b);                    
            Console.WriteLine("po {0},{1}", a, b);

            string s1 = "ahoj";
            string s2 = "čau";

            Console.WriteLine("pred {0},{1}", s1, s2);
            Swapper.Swap<string>(ref s1, ref s2);
            Console.WriteLine("po {0},{1}", s1, s2);

            Nakladak n1 = new Nakladak { VykonMotoru = 100 };
            Nakladak n2 = new Nakladak { VykonMotoru = 99 };

            Osobak o1 = new Osobak { VykonMotoru = 500 };
            Osobak o2 = new Osobak { VykonMotoru = 40 };

            SpravcaAut <Nakladak> spravcaNakladakov = new SpravcaAut<Nakladak>();
            SpravcaAut<Osobak> spravcaOsobakov = new SpravcaAut<Osobak>();

            spravcaOsobakov.PrehodMotrory(o1, o2);
            spravcaNakladakov.PrehodMotrory(n1, n2);



            Console.ReadKey();

        }
    }
}
