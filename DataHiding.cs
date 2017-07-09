using System;

namespace OOPS_Cocepts
{
    class Person
    {
        public int Id;
        public String Name;
        public int Age;
        public void work(){
            System.Console.WriteLine("It Works");
        }
    }
    class Employees:Person{
        public int salary;
        public String OfficeName;
        public new void work(){
            System.Console.WriteLine("It Earns");
        }
    }
}