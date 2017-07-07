using System;

namespace OOPS_Cocepts{
    class Implemeting_Class{
        public int marks;
        public String firstname;
        public String lastName;

        public void GetDetails(){
            int Percentage = marks*100/50;
            String Fullname = firstname+" "+lastName;
            Console.WriteLine("Percentage is : {0}",marks);
            Console.WriteLine("Full Name is : {0}",Fullname);
        }
    }
}