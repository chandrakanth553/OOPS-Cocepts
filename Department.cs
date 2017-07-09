using System;

namespace OOPS_Cocepts
{
    class Department
    {
        public int Dept_Id;
        public String Dept_Name;
        Employee[] emplist;

        public Department()
        {
            Dept_Id=641;
            Dept_Name = "Computers";
            emplist = new Employee[3]
            {
                new Employee{id=101, Name="Chaithu" , Email="chanu@gmail.com", Gender="Male"},
                new Employee{id=102, Name="Chandu" , Email="Chandu@gmail.com", Gender="Male"},
                new Employee{id=103, Name="Prasanna" , Email="Prassu@gmail.com", Gender="Female"},
            };
        }
        public Employee GetEmployee(int Emp_Id)
        {
            foreach(Employee emp in emplist)
            {
                if(Emp_Id == emp.id)
                {
                    return emp;
                }
            }
            return null;
        }
        public Employee GetEmployee(String Name)
        {
            foreach(Employee emp in emplist)
            {
                if(Name == emp.Name)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee this[int id]
        {
            get
            {
                foreach(Employee emplo in emplist)
                {
                if(id == emplo.id)
                {
                    return emplo;
                }
                
                }
            return null;
            }
        }
        public Employee this[String name]
        {
            get
            {
                foreach(Employee emp in emplist)
                {
                if(name == emp.Name)
                {
                    return emp;
                }
                
                }
                return null;
            }
        
        }
    }
}