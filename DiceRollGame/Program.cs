using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] blah = new int[6];

            for (int i = 0; i < 6; i++)
            {
                blah[i] = 1 + i;

                Console.WriteLine(blah[i]);
                Console.WriteLine(r.Next(1, 7));
            }

            for (int i = 0; i < 100; i++)
            {
                int roll = r.Next(6);

                blah[roll]++;
            }
        }
    }
}