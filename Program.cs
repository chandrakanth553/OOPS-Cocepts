using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
           // Creating Intsance of a class using Constructor Method

           Implemeting_Class IC = new Implemeting_Class();

           //Initiling Class Member
           IC.firstname="Chandra";
           IC.lastName = "Kanth";
           IC.marks = 45;

           //Calling Class Methods

           IC.GetDetails();

        }
    }
}
