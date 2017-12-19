using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WorkOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Again we read the input
            var days = int.Parse(Console.ReadLine());
            var kilometersFirstDay = double.Parse(Console.ReadLine());

            //Here we loop in order to read everyday increasment procents
            //Also we need a variable keeping whole kilometers runned
            //We could say that variable is starting with kilometers runned first day..right?!
            var kilometersRunned = kilometersFirstDay;
            var kilometersRunnedPerThatDay = kilometersFirstDay;
            for (int i = 0; i < days; i++)
            {
                var increasment = int.Parse(Console.ReadLine()) / 100.0;

                //On every step we should increase the kilometers in order to find runned per that day
                kilometersRunnedPerThatDay = kilometersRunnedPerThatDay + (increasment * kilometersRunnedPerThatDay);

                //Now we should keep it in a variable
                kilometersRunned += kilometersRunnedPerThatDay;
            }

            //Now we do the check after that hard formula
            if (kilometersRunned >= 1000)
            {
                //We just print it rounded to the bigger number
                //We use Math.Ceiling
                var overRunned = Math.Ceiling(kilometersRunned - 1000);
                Console.WriteLine($"You've done a great job running {overRunned} more kilometers!");
            }
            else
            {
                //We calculate kilometers she hadn't completed to run
                var kilometersNeededMore = Math.Ceiling(1000 - kilometersRunned);
                //And we print them
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {kilometersNeededMore} more kilometers");
            }

        }
    }
}
