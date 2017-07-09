using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            //Knowing object using Indexers
            String email = dept[101].Email;
            Console.WriteLine(email);
            //Knowing object using Method
            String email_without = dept.GetEmployee(101).Email;
            Console.WriteLine(email_without);
        }
    }
}
