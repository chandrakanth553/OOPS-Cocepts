using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Structure Structure1 = new Structure();
           Structure1.method();
           Structure1.Id = 10;
           System.Console.WriteLine(Structure1.Id);
           Structure Structure2 = Structure1;
           Structure2.method();
           Structure2.Id = 20;
           System.Console.WriteLine(Structure1.Id);
           System.Console.WriteLine(Structure2.Id);

        }

        
    }
}
