using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
           Person P1 = new Person();
           P1.work();
           //Using New Keyword to Data Hide From Parent Class
           Employees P2 = new Employees();
           P2.work();
        }
    }
}
