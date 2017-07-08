using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling Base Class Method
            Person P1 = new Person();
            P1.Name = "Chandrakanth";
            P1.id = 101;
            Console.WriteLine(P1.GetDetails());

            // Initialting Base Class with Child Class
            Person P2 = new Employee();
            P2.Name = "Thadkapally";
            P2.id = 102;
            Console.WriteLine(P2.GetDetails());
            // Initiating the Child class with Child CLass
            /*Its Method Overload runs at Compile time So if you want run Child class method 
            you need to call Child CLass Instanse*/
            Employee P3 = new Employee();
            P3.Name = "Chandu";
            P3.Company = "Amazon";
            Console.WriteLine(P3.GetDetails());
            // Overriding of a class will call child class
            Person P4 = new Student();
            P4.Name = "Chandra";
            Console.WriteLine(P4.GetDetails());
            //Overrriding Sealed Class
            Person P5 = new Manager();
            P5.Name="Kanth";
            Console.WriteLine(P5.GetDetails());
            // Calling parent Class
            MethodOverriding MO = new MethodOverriding();
            MO.Name="Thadakapally";
            Console.WriteLine(MO.GetDetails());
            

        }
    }
}
