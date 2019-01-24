using System;

namespace c01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to online bakery items ordering!!");
            var name = "";
            var ordername = "";
            var address = "";
            var ordernumber = 0;
            var amount = 0.0;
            var rating = 0.0m;
            var extra_amt = 20;
            var extradrinks = "";
            var extradrinks_comp = false;
            var EXIT_CHAR = 'Q';
            do
            {
                while (name == "")
                {
                    Console.WriteLine("please enter your name:");
                    name = Console.ReadLine();
                    Console.WriteLine($"Hi {name}");
                }


                Console.WriteLine("Enter your ordername:");
                ordername = Console.ReadLine();

                switch (ordername)
                {
                    case "cake":
                        ordername = "cake";
                        ordernumber = 01;
                        amount = 75.0;
                        break;
                    case "pizza":
                        ordername = "pizza";
                        ordernumber = 02;
                        amount = 100.0;
                        break;
                    case "default":
                        Console.WriteLine($"default");
                        break;
                }
                
                Console.WriteLine("Please enter your address for delivering the order:");
                address = Console.ReadLine();

                Console.WriteLine("\nDo you need drinks? yes/no");

                extradrinks = Console.ReadLine();
                if (extradrinks == "yes")
                {
                    extradrinks_comp = true;
                    amount = amount + extra_amt;
                }

                Console.WriteLine($"Your amount is {amount}");
                Console.WriteLine("Give me your rating");
                rating = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Do you want to exit?(Type Q to exit)");
                EXIT_CHAR = Convert.ToChar(Console.ReadLine());
            }
            while (EXIT_CHAR != 'Q');



        }
    }
}
