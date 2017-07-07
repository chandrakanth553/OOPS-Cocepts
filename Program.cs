using System;

namespace OOPS_Cocepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //If you have a Model in Class then you will Initilize Objects Like This
            ObjectInitilizer OI1 = new ObjectInitilizer{ Id=700, Name="Chandrakanth", Email="chandu@gmail.com", Gender="Male"};
            ObjectInitilizer OI2 = new ObjectInitilizer{ Id=641, Name="Thadkap", Email="Thadkapa@gmail.com", Gender="Male"};

            Console.WriteLine(OI1.Id);
            Console.WriteLine(OI1.Name);
            Console.WriteLine(OI1.Email);
            Console.WriteLine(OI1.Gender);
            Console.WriteLine("\n\n");
            Console.WriteLine(OI2.Id);
            Console.WriteLine(OI2.Name);
            Console.WriteLine(OI2.Email);
            Console.WriteLine(OI2.Gender);
        }
    }
}
