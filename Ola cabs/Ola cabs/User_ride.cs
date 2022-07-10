using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ola_cabs
{
    class User_ride
    {
        public double NUM_KM
        { get; set; }

        public double UC_KM  
        { get; set; }

        public double SD_RATE
        { get; set; }

        public double f_bill_amount=0;
        public double sd_billrate;


        public void userdata(double NUM_KM, double UC_KM, double SD_RATE )
        {
            this.NUM_KM = NUM_KM;
            this.UC_KM = UC_KM;
            this.SD_RATE = SD_RATE;
        }
        
        public double Calculate()
        {
            if(NUM_KM <100 || NUM_KM>0)
            {

                f_bill_amount = NUM_KM * UC_KM; 

            }
            else
            {
                f_bill_amount = 100*UC_KM+(NUM_KM - 100)*SD_RATE;
                
            }
            return f_bill_amount;
        }



    }
}
