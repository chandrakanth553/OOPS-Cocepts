using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
           // In parent class Instance You can't find Method2
            Class1 c1 = new Class2();
            c1.Method1();
             
            Class2 c2 = new Class2();
            c2.Method1();
            c2.Method2();
            // Calling Constructor uning Inheritence
            Class2 c3 = new Class2();
            // Calling Parameterized Constructor that will Call Parent Parameterized Consstructor 
            // if you are using :base() Method
            Class2 c4 = new Class2();
            //Derived Static Constructor will Execute First then Base one

        }
    }
}
