using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Calling
            Implement I = new Implement();
            I.work();
            //Interfaces
           Details D = new Details();
           D.work();
           Iinetrface1 Iinetrface1= new Details();
           Iinetrface1.Work2();
           Iinterface2 Iinterface2= new Details();
           Iinterface2.Work2();
        }
    }
}
