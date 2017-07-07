using System;

namespace OOPS_Cocepts{
    class ClassMember{
        public int radius;
        public static double PI_Value;

        public double Area(){
            double Area = ClassMember.PI_Value*this.radius*this.radius;
            return Area;
        } 

    }
}