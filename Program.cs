using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using default Constructor 
            Constructor Con1 = new Constructor();
            Console.WriteLine(Con1.Area());

            //Using Paramertaized Constructor
            Constructor Con2= new Constructor(10,20);

            //Using Copy Constructor
            //Here We are using default constructor and Copy to another one
            Constructor Con3 =  new Constructor();
            Con3.radius =20;
            Console.WriteLine(Con3.Area());
            Constructor Con4 = new Constructor(Con3);
            Console.WriteLine(Con4.Area());
            //Static Constructor
            //Here PI Value will Store in Static Constructor that will execute first before then Main Method.

            Console.WriteLine("End Of Project \n \n"); 

            
        }
    }
}
