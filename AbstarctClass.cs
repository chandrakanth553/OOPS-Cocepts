using System;

namespace OOPS_Cocepts{
    abstract class AbstractClass{
        public int Id{get; set;}
        public String Name{get; set;}
        public void PrintName(){
            System.Console.WriteLine("Details are ID: {0}, Name:{1}",Id, Name);
        }
        public abstract void work();
    }
    class Implement:AbstractClass{
        //You have to Overriede abstract Method in Base class using Override Keyword
        public override void work(){
            System.Console.WriteLine("It Abstract Class");
        }
    }
}