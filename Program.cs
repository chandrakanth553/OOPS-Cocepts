using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sealed CLass Cannot be inherited
           SealedClass SC = new SealedClass();
           //It can act as Child class
           SC.ParentMethod();
           SC.PrintMethod();

           //Partial Class can be work for Edit multiple times
           PartialClass PC = new PartialClass();
           PC.Method1();
           PC.Method2();

           //Generic Class
           GenericClass<int, String> GC = new GenericClass<int, String>();
           GC.Id = 101;
           System.Console.WriteLine(GC.Id);
           GC.Method(102,"Chandrakanth");
        }
    }
}
