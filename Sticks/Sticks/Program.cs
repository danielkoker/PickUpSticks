using System;

namespace Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int stickCount;

            Console.WriteLine("Welcome to a game of pick up sticks!");
            // Console.WriteLine(""); Write game instructions here.
            Console.WriteLine("You cannot win, resistance is futile.");
            Console.WriteLine("How many sticks would you like to play with? You can choose equal to or greater than 5 and less than or equal to 40.");
            stickCount = GetNumber();

            if (stickCount % 4 == 1)
            {
                Console.WriteLine("You need all the help you can get. You shall go first!");
                UsersTurn(stickCount);
      

            }
            else
            {
                Console.WriteLine("I'm faster, so naturally, I will go first.");
                ComputersTurn(stickCount);
            }





        }
        static int GetNumber() // gets initial number from user and verifies that it is within the parameters of the game
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
            else if (x <= 40 && x >= 5)
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
       
        static void ComputersTurn(int stickCount)
        {
            if (stickCount % 4 == 3)
            {
                stickCount = stickCount - 2;
                Console.WriteLine("I remove 2 sticks. Sticks remaining: " + stickCount);
                UsersTurn(stickCount);
            }
            else if (stickCount % 4 == 2)
            {
                stickCount = stickCount - 1;
                Console.WriteLine("I remove 1 stick. Sticks remaining: " + stickCount);
                UsersTurn(stickCount);

            }
            else if (stickCount % 4 == 0)
            {
                stickCount = stickCount - 3;
                Console.WriteLine("I remove 3 stick. Sticks remaining: " + stickCount);
                UsersTurn(stickCount);

            }
            else if (stickCount == 1)
            {
                Console.WriteLine("You lose.");

            }
            else
            {

            }
            
        }

        static void UsersTurn(int stickCount)
            {
            if(stickCount == 1)
            {
                Console.WriteLine("You Lose, there is only one stick remaining.");
            }
            else
            {
                Console.WriteLine("How many sticks would you like to remove? 1, 2, or 3");
                int x = Convert.ToInt32(Console.ReadLine());
                if ((x < 1 || x > 3) && x != 1)
                {
                    Console.WriteLine("You Cheated! You lose!");
                }
                else
                {
                    Console.WriteLine("You removed: " + x + " sticks.");
                    stickCount = stickCount - x;
                    Console.WriteLine("There are now " + stickCount + " sticks remaining.");
                    ComputersTurn(stickCount);
                }
            }

            }
    }
}
