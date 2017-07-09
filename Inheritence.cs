using System;

namespace OOPS_Cocepts{
    class Class1{
        public Class1(){
            System.Console.WriteLine("Base class default Constructor");
        }

        public Class1(int a){
            System.Console.WriteLine("Parameterized Constructor Value:"+a);
        }
        static Class1(){
            System.Console.WriteLine("Base Class Static Constructor");
        }
        public void Method1(){
            System.Console.WriteLine("Parent Method");
        }
    }
    class Class2:Class1{
        public Class2(){
            System.Console.WriteLine("Child Class default Constructor");
        }
        public Class2(int b):base(b)
        {
            System.Console.WriteLine("Child Class Parameterized Constructor: "+b);
        }
        static Class2(){
            System.Console.WriteLine("Child Class Staic COnstructor");
        }
        public void Method2(){
            System.Console.WriteLine("Child Method");
        }
    }
}
