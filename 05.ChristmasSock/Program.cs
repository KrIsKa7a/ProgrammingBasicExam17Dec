using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasSock
{
    class Program
    {
        static void Main(string[] args)
        {
            //We read the input
            var n = int.Parse(Console.ReadLine());

            //The christmas sock seems to start with three unique rows so don't we start with them?!
            //The lenght seems to be 2 * n + 2
            //The side pipes are 2 so the '-' symbols are 2 * n
            //Let's get to work

            //The first row
            Console.WriteLine("|" + new string('-', 2 * n) + "|");

            //The second row
            Console.WriteLine("|" + new string('*', 2 * n) + "|");

            //The third row is exactly the same like first one
            Console.WriteLine("|" + new string('-', 2 * n) + "|");

            //Let's get up with the hardest part
            //The first three rows we printed just now summed with next rows seems to be 2 * n
            //So the rows with equation are 2 * n  - 3

            //We declare some additionnal variables to help us with the count
            var strangeSymbolCount = 2;
            //The '-' count seems to be like whole lenght(2 * n + 2) - 2 - strangeSymbolsCount / 2
            //But let's split that lines
            //Let's implement this difficult equation
            var tireCount = ((2 * n + 2) - 2 - strangeSymbolCount) / 2;

            for (int i = 0; i < n - 1; i++)
            {
                //Okey now let's print
                Console.WriteLine("|" + new string('-', tireCount) + 
                    new string('~', strangeSymbolCount) + new string('-', tireCount) + "|");

                //On each step we should do smth with the count
                //And that is to increase the middle part with two and decrease '-' with 1 
                strangeSymbolCount += 2;
                tireCount --;
            }

            //Now for next n - 2 lines we need to increase the tire and decrease the strange symbol

            tireCount += 2;
            strangeSymbolCount -= 4;

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string('-', tireCount) +
                    new string('~', strangeSymbolCount) + new string('-', tireCount) + "|");

                strangeSymbolCount -= 2;
                tireCount++;
            }

            //The dots count seems to be n * 2 + 1
            //So let's print the next lines
            //The next lines which seems to have equation are n + 2

            //Some helpful variables of course! :)
            var dotsCount = n * 2 + 1;
            var tireLeftCount = 0;

            for (int i = 0; i < n + 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine(new string('-', tireLeftCount) + "\\" +
                        new string('.', n - 2) + "MERRY" + new string('.', n - 2) + "\\");
                }
                else if (i == n / 2 + 2)
                {
                    Console.WriteLine(new string('-', tireLeftCount) + "\\" +
                        new string('.', n - 2) + "X-MAS" + new string('.', n - 2) + "\\");
                }
                else
                {
                    //We should escape special chars
                    Console.WriteLine(new string('-', tireLeftCount) + "\\" + new string('.', dotsCount) +
                        "\\");
                }

                //The dots count is static so we don't change it
                //We need just to increase the '-' count by 1
                tireLeftCount++;

                //Let's check for special signs row
                //First one seems to be n / 2
                //But we will do it above
               
            }

            //Finally the last line *_*
            Console.WriteLine(new string('-', tireLeftCount) + "\\" + 
                new string('_', dotsCount) + ")");
        }
    }
}
