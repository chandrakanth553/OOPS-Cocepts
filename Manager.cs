using System;

namespace OOPS_Cocepts{
    class Manager:Person{
        public sealed override String GetDetails(){
            return Name+" "+"TeamName";
        }

    }
}