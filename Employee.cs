using System;

namespace OOPS_Cocepts
{
    class Employee:Person
    {
        public String Company;
        public new String GetDetails()
        {
            return Name+Company;
        }
    }

}
    
