using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV
{

    class usd : Devise,IDevise
    {
        private double tauxmad =9.27;
        private double tauxeur = 1.08;
        private Devise val;

        public usd(Devise v)
        {
            this.val = v;

        }

        public Devise convertto(string ndev)
        {
            
            if (ndev == "eur")
            {
                

                return Devise.Taux(val, tauxeur, ndev);

            }

            else if (ndev == "mad")
            {

             
                return Devise.Taux(val, tauxmad, ndev);
                
            }
            else
                return val;
        }

    }
}
