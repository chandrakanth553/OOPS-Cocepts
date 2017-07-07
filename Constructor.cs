using System;

namespace OOPS_Cocepts{
    class Constructor{
        public static double PI;
        public int radius;

        public Constructor(){
            this.radius=15;
        }
        public Constructor(int length, int width){
            Console.WriteLine(RectangleArea(length,width));
        }
        public Constructor(Constructor Constructor){
            this.radius = Constructor.radius;
            
        }

        static Constructor(){
            Constructor.PI=3.14;
        }
        public double Area(){

            return PI*radius*radius;
        } 

        public int RectangleArea(int length, int width){
            return length*width;
        }


    }
}