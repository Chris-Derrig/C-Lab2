using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            bool repeat = true;
            decimal length1 = 0.0m;
            decimal width1 = 0.0m;

            Console.WriteLine("Welcome to the Room Dimension Generator");

            while (repeat)
            {
                while (repeat)
                {
                    Console.WriteLine("\nHi! Please enter your value for length?");
                    string input1 = Console.ReadLine();
                    decimal.TryParse(input1, out length1);

                    decimal num1 = 0.0m;
                    if (!decimal.TryParse(input1, out num1))
                    {
                        Console.WriteLine("Sorry, please enter a number");
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                repeat = true;

                while (repeat)
                {
                    Console.WriteLine("\nHi! Please enter your value for width?");
                    string input2 = Console.ReadLine();
                    decimal.TryParse(input2, out width1);

                    decimal num2 = 0.0m;
                    if (!decimal.TryParse(input2, out num2))
                    {
                        Console.WriteLine("Sorry, please enter a number");
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                Console.WriteLine("\nThanks!, The PERIMETER if the room is " + ((length1 * 2) + (width1 * 2)));
                Console.WriteLine("         The AREA of the room is " + ((length1) * (width1)));
                Console.WriteLine("\n\nWould you like to run the program again. ('Y' or 'N')\n");
                string doAgain = Console.ReadLine();

                while (tryAgain)
                {
                    if (string.IsNullOrEmpty(doAgain))
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        doAgain = Console.ReadLine();
                    }

                    if (doAgain == "n" || doAgain == "N")
                    {
                        Console.WriteLine("\nThanks for the chat.  Have a great day!");
                        return;
                    }
                    tryAgain = false;
                }
                if (doAgain == "y" || doAgain == "Y")
                {

                }
                repeat = true;
                tryAgain = true;
            }
        }
    } 
}

