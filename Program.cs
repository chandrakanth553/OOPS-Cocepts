using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading MO = new MethodOverloading();
            MO.length = 10;
            MO.width = 20;

            // Calling Method with No Parameters
            Console.WriteLine("Area of A Rectange with No Parameters:"+MO.Area());

            //Calling Method with with one Parameter
            Console.WriteLine("Area of A Circle with One Parameter:"+MO.Area(15));

            //Calling Method with two Parameters
            Console.WriteLine("Area of A Rectange with Two Parameters:"+MO.Area(20,30));

            //Calling Method with Three Parameters
            Console.WriteLine("Area of A Cube with Three Parameters:"+MO.Area(10,20,30));
        }
    }
}
