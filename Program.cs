using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
           Enum E = new Enum{Id=101,Name = "Chandrakanth", Gender = gender.Male };
           System.Console.WriteLine(E.Gender);
           int Gen = (int)E.Gender;
           System.Console.WriteLine(Gen);
           
        }
    }
}
