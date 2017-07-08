using System;

namespace OOPS_Cocepts{
    class Person{
        public int id;
        public String Name;
        public virtual String  GetDetails(){
            return Name+id;
        }
    }
}