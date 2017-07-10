using System;

namespace OOPS_Cocepts{
    
    class ParentClass{
        public void ParentMethod(){
            System.Console.WriteLine("It is Parent Method");
        }
    }
    sealed class SealedClass:ParentClass{
        // Sealed Class Cannot be as a Parent Class
        public void PrintMethod(){
            System.Console.WriteLine("It Prints Name");
        }
    }
}