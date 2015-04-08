using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipACoin(1000);
            FlipForHeads(1000);
            Console.ReadKey();
        }
        public static void FlipACoin(int numberOfFlips)
        {
            Random randomFlip = new Random();
            int numberOfHeads = 0;
            int numberOfTails = 0;
            for (int i = 0; i < numberOfFlips; i++)
            {
                if (randomFlip.Next(2) == 0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }
            Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
            Console.WriteLine("Number of Heads: " + numberOfHeads);
            Console.WriteLine("Nummber of Tails: " + numberOfTails);
        }
        public static void FlipForHeads(int numberOfHeads)
        {
            Random randomFlip = new Random();
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            while (numberOfHeadsFlipped != numberOfHeads)
            {
                if (randomFlip.Next(2) == 0)
                {
                    numberOfHeadsFlipped += 1;
                    totalFlips += 1;
                }
                else
                    totalFlips += 1;
            }
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " of heads.");
            Console.WriteLine("It took " + totalFlips + " flips to find " + numberOfHeads + " of heads.");
        }
    }
}
