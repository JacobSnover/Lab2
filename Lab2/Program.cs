using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, what is your name: ");
            string name = Console.ReadLine();
            while (true)
            {
                int value;
                Console.Write($"Okay {name} please give me a number between (1-100): ");
                string input = Console.ReadLine();

                while (!int.TryParse(input, out value) || value <= 0 || value > 100)
                {
                    Console.WriteLine($"Sorry {name} but that is not a proper response. ");
                    Console.Write($"Okay {name} please give me a number between (1-100): ");
                    input = Console.ReadLine();

                }

                if (value % 2 == 0 && value > 0 && value <= 100)
                {

                    if (value >= 2 && value < 25)
                    {
                        Console.WriteLine($"Thank you {name}, {value} is an even number and less then 25. ");


                    }
                    else if (value >= 26 && value <= 60)
                    {
                        Console.WriteLine($"Thank you {name} your input is an even number. ");

                    }
                    else if (value > 60)
                    {
                        Console.WriteLine($"Thank you {name}, {value} is an even number. ");

                    }


                }
                if (value % 2 != 0 && value > 60)
                {
                    Console.WriteLine($"Thank you {name}, {value} is and odd number. ");
                }
                else if (value % 2 != 0)
                {
                    Console.WriteLine($"Thank you {name}, that is an odd number. ");
                }

                while (true)
                {

                    Console.Write("Do you want to continue Yes or No? ");
                    string test = Console.ReadLine().ToLower();

                    if (test == "y" || test == "yes")
                    {
                        break;
                    }
                    else if (test == "n" || test == "no")
                    {
                        Console.WriteLine("Bye");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                }
                continue;
            }

        }
    }
}
