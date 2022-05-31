using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV
{
    class Program
    {
        static void Main(string[] args)
        {

            Devise dev1 = new Devise(30.00, "eur");

            dev1.Afficher();
            eur e=new eur(dev1);

            Console.WriteLine("\n \t ********Currency Converter********");
            e.convertto("usd");
            e.convertto("mad");

           
            
            Devise dev=new Devise(100.00,"mad");
            dev.Afficher();
           
            mad m = new mad(dev);

            Console.WriteLine("\n \t ********Currency Converter********");
            m.convertto("eur");

            m.convertto("usd");


            Devise dev3 = new Devise(60.00, "usd");
            dev3.Afficher();

            usd d = new usd(dev3);

            Console.WriteLine("\n \t ********Currency Converter********");
            d.convertto("eur");

            d.convertto("mad");

        }
    }
}
