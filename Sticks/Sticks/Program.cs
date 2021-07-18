using System;

namespace Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int stickCount;

            Console.WriteLine("Welcome to a game of pick up sticks!");
            Console.WriteLine("You cannot win, resistance is futile.");
            Console.WriteLine("How many sticks would you like to play with? You can choose between 5 and 40.");
            stickCount = GetNumber();

            if (stickCount % 4 == 1)
            {
                Console.WriteLine("You need all the help you can get. You shall go first!");
            }
            else
            {
                Console.WriteLine("I'm faster, so naturally, I will go first.");
            }




        }
        static int GetNumber() // gets number from user and verifies that it is within the parameters of the game
        {
            Console.WriteLine("Choose the total number of sticks: ");
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
                Console.WriteLine("I dont know how you got here, but congrats, I guess you win.");
                return 0;
            }
        }
       
        static int ComputersTurn(int stickCount)
        {
            if (stickCount % 4 == 3)
            {
                return 2;
            }
            else if (stickCount % 4 == 2)
            {
                return 1;
            }
            else if (stickCount % 4 == 0)
            {
                return 3;
            }
            else if (stickCount == 1)
            {
                return 0;
            }
            else
            {
                return -1;
            }
            
        }

        static int UserFirstPlay()
            {
            Console.WriteLine("How many sticks would you like to remove? 1, 2, or 3");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 1 || x > 3)
            {
                Console.WriteLine("You Cheated!");
            }
            return x;
            } 

    }
}
