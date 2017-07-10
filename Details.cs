using System;

namespace OOPS_Cocepts{
    class Details:Inherited,Iinetrface1, Iinterface2{
        public void work(){
            System.Console.WriteLine("It print Details of Details class");
        }
        void Iinetrface1.Work2(){
            System.Console.WriteLine("It WOrk 2 Method");
        }
        void Iinterface2.Work2(){
            System.Console.WriteLine("It WOrk 2 Method");
        }
    }
}