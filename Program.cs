using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties p = new Properties();
            p.Intitial_Amount = 1000;
            p.Intrest = 10.4f;
            Console.WriteLine(p.Intitial_Amount);
            Console.WriteLine(p.Intrest);;
            
        }
    }
}
