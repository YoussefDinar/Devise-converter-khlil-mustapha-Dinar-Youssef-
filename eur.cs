using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV
{
    class eur : Devise, IDevise
    {
        private double tauxusd = 1.05;
        private double tauxmad = 10.65;
        private Devise val;

        public eur(Devise v)
        {
            this.val = v;

        }

        public Devise convertto(string ndev)
        {
          
            if (ndev == "mad")
            {
               
                return Devise.Taux(val, tauxmad, ndev);
     
            }

            else if (ndev == "usd")
            {
               
                return Devise.Taux(val, tauxusd, ndev);

            }
            else
                return val;
        }


    }
}
