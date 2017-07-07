using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Careating Instances of Class using Constructor
            ClassMember CM = new ClassMember();

            //Careting static member using Class Name
            ClassMember.PI_Value=3.14;

            //Creating Instance Member using Instance
            CM.radius=5;
            Console.WriteLine("Area of Circle is:"+CM.Area());
        }
    }
}
