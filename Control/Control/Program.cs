using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            long orderNumber;
            string day;
            string product1;
            string product2;
            float price1;
            float price2;
            float priceTotal;

           //Console.WriteLine("Hello Barmen! Enter the name: ");
            name = "Vitaliy";
           //Console.WriteLine("What is number of order?" );
           orderNumber = 666;
            //Console.WriteLine("What is the day of week today?");
            day = "thursday";
           Console.WriteLine("What is product 1 name?");
           product1 = Console.ReadLine();
           Console.WriteLine("What is product 1 price?");
           price1 = float.Parse(Console.ReadLine());

           Console.WriteLine("What is product 2 name?");
           product2 = Console.ReadLine();
           Console.WriteLine("What is product 2 price?");
           price2 = float.Parse(Console.ReadLine());

           priceTotal = price1 + price2;

           Console.WriteLine("Hello, " + name+  "\\\tToday is " + day);
           Console.WriteLine("Number of order:  #" + orderNumber );
           Console.WriteLine("1. {0} \t {1}\n2. {2} \t {3}", product1, price1, product2, price2);
            Console.WriteLine("Total: ".ToUpper() + priceTotal);
            Console.ReadLine();
        





        }
    }
}
