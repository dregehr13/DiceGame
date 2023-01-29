using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollGame
{
    public class Game
    {
        //Write a program that simulates the rolling of two 6-sided dice. Use an Array to keep track of the
        //number of times that each total number is thrown.In other words, keep track of how many times
        //the combination of the two simulated dice is 2, how many times the combination is 3, and so on,
        //all the way up through 12.
        //Allow the user to choose how many times the “dice” will be thrown.Then, once the dice have
        //been thrown the specified number of times, print a histogram (using the * character) that shows
        //the total percentage each number was rolled.Each* will represent 1% of the total rolls.

        Random r = new Random();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DiceRollGame!");
            while (true)
            {
                // Request number of rolls
                Console.WriteLine("How many times do you want to roll?");

                bool invalidInput = true;
                int totalRolls = -1;

                while (invalidInput)
                {
                    // Saves number of roles
                    string inputRolls = Console.ReadLine();

                    try
                    {
                        totalRolls = Int32.Parse(inputRolls);
                        invalidInput = false;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Not a valid integer");
                        invalidInput = true;
                    }
                }

                Game g = new Game();
                int[] results = new int[totalRolls];

                int total2 = 0;
                int total3 = 0;
                int total4 = 0;
                int total5 = 0;
                int total6 = 0;
                int total7 = 0;
                int total8 = 0;
                int total9 = 0;
                int total10 = 0;
                int total11 = 0;
                int total12 = 0;

                //Roll 2 dice
                for (int i = 0; i < totalRolls; i++)
                {
                    //Store in array
                    results[i] = g.Roll2();
                }

                //Count number of occurrences for each
                for (int i = 0; i < totalRolls; i++)
                {
                    if (results[i] == 2)
                    {
                        total2++;
                    }
                    else if (results[i] == 3)
                    {
                        total3++;
                    }
                    else if (results[i] == 4)
                    {
                        total4++;
                    }
                    else if (results[i] == 5)
                    {
                        total5++;
                    }
                    else if (results[i] == 6)
                    {
                        total6++;
                    }
                    else if (results[i] == 7)
                    {
                        total7++;
                    }
                    else if (results[i] == 8)
                    {
                        total8++;
                    }
                    else if (results[i] == 9)
                    {
                        total9++;
                    }
                    else if (results[i] == 10)
                    {
                        total10++;
                    }
                    else if (results[i] == 11)
                    {
                        total11++;
                    }
                    else if (results[i] == 12)
                    {
                        total12++;
                    }
                    else
                    {
                        Console.WriteLine("uh oh");
                    }
                }

                //Print historgram
                Console.WriteLine("2:  " + g.ConvertToStars(total2, totalRolls));
                Console.WriteLine("3:  " + g.ConvertToStars(total3, totalRolls));
                Console.WriteLine("4:  " + g.ConvertToStars(total4, totalRolls));
                Console.WriteLine("5:  " + g.ConvertToStars(total5, totalRolls));
                Console.WriteLine("6:  " + g.ConvertToStars(total6, totalRolls));
                Console.WriteLine("7:  " + g.ConvertToStars(total7, totalRolls));
                Console.WriteLine("8:  " + g.ConvertToStars(total8, totalRolls));
                Console.WriteLine("9:  " + g.ConvertToStars(total9, totalRolls));
                Console.WriteLine("10: " + g.ConvertToStars(total10, totalRolls));
                Console.WriteLine("11: " + g.ConvertToStars(total11, totalRolls));
                Console.WriteLine("12: " + g.ConvertToStars(total12, totalRolls));

                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Play Again!");
            }
        }
        private int RollNumber()
        {
            int roll = r.Next(1,7);
            return roll;
        }

        public int Roll2()
        {
            int rollTotal = RollNumber() + RollNumber();
            return rollTotal;
        }

        public string ConvertToStars(int num, int den)
        {
            double percent = (double)num / den * 100;
            int roundedPercent = (int)Math.Round(percent);
            string stars = new string('*', roundedPercent);

            return stars;
        }

    }
}