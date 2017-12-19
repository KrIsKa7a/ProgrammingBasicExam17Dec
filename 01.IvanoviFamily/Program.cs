using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IvanoviFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            //Our first job is to read the input exactly as it was said in the document
            var budget = decimal.Parse(Console.ReadLine());
            var firstKidPresentPrice = decimal.Parse(Console.ReadLine());
            var secondKidPresentPrice = decimal.Parse(Console.ReadLine());
            var thirdKidPresentPrice = decimal.Parse(Console.ReadLine());


            //We calculate the total money for the presents
            //We just follow the algorithm defined in the constrains
            var forPresents = firstKidPresentPrice + secondKidPresentPrice +
                thirdKidPresentPrice;

            //That is our money left after all the purchases
            var moneyLeft = budget - forPresents;

            //Then we just need to remove the 10% tax
            moneyLeft -= 0.10m * moneyLeft;

            //Now we need just to print the remaining moneys
            //They should be formatted two decimal digits after floating delimiter
            //We do that with placeholders
            //Our special tag for that kind of formatting was 'f2'
            Console.WriteLine($"{moneyLeft:f2}");

            //Ohh what a funny and simple problem was that! :))
        }
    }
}
