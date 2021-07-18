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


        }
        static int GetNumber() // gets number from user and verifies that it is within the parameters of the game
        {
            Console.WriteLine("Choose your number of sticks: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 5)
            {
                Console.WriteLine("That number is too low, do you even know your numbers?");
                Console.WriteLine("Try again.");
                GetNumber();
                return 0;
            }
            else if (x > 40)
            {
                Console.WriteLine("That number is too high, but to be fair, I didn't think you could count that high.");
                Console.WriteLine("Try again.");
                GetNumber();
                return 0;
            }
            else if (x < 40 && x > 5)
            {
                Console.WriteLine("Ahh, " + x + " a good number.");
                return x;
            }
            else
            {
                Console.WriteLine("I dont know how you got here, but congrats! You win.");
                return 0;
            }
        }

    }
}
