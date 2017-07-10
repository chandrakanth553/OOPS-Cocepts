using System;

namespace OOPS_Cocepts{
    class GenericClass<T1, T2>{
        public T1 Id;
        public void Method(T1 p, T2 q){
            System.Console.WriteLine("It Prints {0}, {1}",p,q);
        }
    }

}