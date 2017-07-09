using System;
namespace OOPS_Cocepts{
    class Properties{
        int Init_Amount;
        float rate;

        public int Intitial_Amount
        {
            set{
                if(value<1000)
                {
                    Console.WriteLine("Your Amount is less Than 1000");

                }
                else
                {
                    Init_Amount = value;
                }
                
            }
            get{
                return Init_Amount;
            }
            
        }
        public float Intrest{
            set{
                this.rate= value;
            }
            get{
                return rate;
            }
        }
    }
}