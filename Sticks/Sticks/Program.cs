using System;

namespace Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialStickCount;

            Console.WriteLine("Welcome to a game of pick up sticks!");
            Console.WriteLine("You cannot win, resistance is futile.");
            Console.WriteLine("How many sticks would you like to play with? You can choose between 5 and 40.");
            initialStickCount = GetNumber();


            if (initialStickCount < 5)
            {
                Console.WriteLine("That number is too low, do you even know your numbers?");
                Console.WriteLine("Try again.");
                GetNumber();
            }
            else if (initialStickCount > 40)
            {
                Console.WriteLine("That number is too high, but to be fair, I didn't think you could count that high.");
                Console.WriteLine("Try again.");
                GetNumber();
            }
            else
            {
                Console.WriteLine("Ahh, " + initialStickCount + "a good number.");
            }




        }
        static int GetNumber()
        {
            Console.WriteLine("Choose your number of sticks: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

    }
}
