using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV
{
    class Devise
    {
        private double Valeur;
        private string name;


       public Devise()
        {
            this.Valeur = 0.0;
            this.name = null;
        }

        public Devise(double Valeur, string name)
        {
            this.Valeur = Valeur;
            this.name = name;
        }

        public void Afficher()
        {
            Console.Write("\n \n Valeur :  " + this.Valeur);
            Console.Write("  Currency : " + this.name);
        }

        
        public static Devise  Taux(Devise d1, double d2,string n)
        {
            d1.Valeur *= d2;
            d1.name = n;
            
            d1.Afficher();
            return d1;
        }

     


    }
}
