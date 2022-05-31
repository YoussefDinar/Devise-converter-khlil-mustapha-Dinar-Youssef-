using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV
{
    class mad : Devise, IDevise
    {
        private double tauxusd = 1.1;
        private double tauxeur = 0.094;
        private Devise val;

        public  mad(Devise v)
        {
            this.val = v;  

        }

        public Devise convertto(string ndev)
        {
            
            if (ndev == "eur")
            {
                return Devise.Taux(val,tauxeur,ndev);
              
                
                
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
