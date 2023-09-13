using System;

namespace RunTImePolymorpshim
{

    public abstract class user
    {
        public abstract void DisplayInfo();
        public string UserName { get; set; }
    }

    public class Customer : user
    {
        public string Address { get; set; }
        public string Mobile { get; set; }

        public override void DisplayInfo()
        {
            Console.Write("Enter Full Name: ");
            UserName = Console.ReadLine();
            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            Mobile = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Customer Details");
            Console.WriteLine("Full Name: " + UserName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Mobile: " + Mobile);
        }

    }
    public class Employee : user
    {
        public string BillAmount { get; set; }
        public string BillNumber { get; set; }

        public override void DisplayInfo()
        {

            Console.Write("Enter Full Name: ");
            UserName = Console.ReadLine();
            Console.Write("Enter BillAmount: ");
            BillAmount = Console.ReadLine();
            Console.Write("Enter BillNumber: ");
            BillNumber = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Bill Details");
            Console.WriteLine("Employee Name: " + UserName);
            Console.WriteLine("Bill Amount: " + BillAmount);
            Console.WriteLine("Bill No: " + BillNumber);
        }
    }
    public class Display
    {
        public void DisplayInfo(user type)
        {
            type.DisplayInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("customer types?");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. employee");
            Console.Write("enter the number of your choice: ");
            string userinput = Console.ReadLine();

            if (int.TryParse(userinput, out int choice))
            {
                Display D = new Display();
                user user = choice == 1 ? (user)new Customer() : (user)new Employee();
                D.DisplayInfo(user);
            }
            else
            {
                Console.WriteLine("invalid input. please enter a number.");
            }
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
