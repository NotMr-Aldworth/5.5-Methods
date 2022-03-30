using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            bool done = false;


            Console.WriteLine("Enter a number for an animal");
            Console.WriteLine("1 for a Camel");
            Console.WriteLine("2 for a Bat");
            Console.WriteLine("3 for a Philly Cheese Steak");

            while (Int32.TryParse(Console.ReadLine(), out selection))
            {
                if (selection == 1)
                    Camel();
                else if (selection == 2)
                    Bat();
                else if (selection == 3)
                    Philip();
                else
                    Console.WriteLine("Please enter a valid selection");

            }
            Console.ReadLine();
        }
     public static void Camel()
        {
            Console.WriteLine("       __");
            Console.WriteLine("      |  |");
            Console.WriteLine("     (|00|)");
            Console.WriteLine("      (==)");
            Console.WriteLine("    ___||___");
            Console.WriteLine("   / _ .. _ \\");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
     public static void Bat()
        {
            Console.WriteLine("Bat");
        }
    public static void Philip()
        {
            Console.WriteLine("Philly");
        }
    
    }


}
