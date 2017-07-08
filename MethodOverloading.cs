using System;

namespace OOPS_Cocepts{
    class MethodOverloading{
        public int length, width;
        public int Area(){
            return length*width;
        }

        public double Area(int radius){
            return 3.14*radius*radius;
        }

        public int Area(int length, int width){
            return length*width;
        }

        public int Area(int length,int width,int height){
            return length*width*height;
        }
    }
}