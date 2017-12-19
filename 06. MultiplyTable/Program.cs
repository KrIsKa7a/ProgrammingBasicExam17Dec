using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Okey last problem => last solution
            //Let's read all input
            var number = int.Parse(Console.ReadLine());

            //But how to get each digit
            //We talked about that almost every lecture
            //With splitting by 10 we remove the last digit of a number
            //We already should know that algorithm
            var thirdDigit = number % 10;
            number /= 10;
            //Let's do that again for other digits
            var secondDigit = number % 10;
            number /= 10;
            //And again
            var firstDigit = number % 10;

            //That's all we need
            //But they said that the number is reversed so we will take the number in the loops reversed
            //And as we said before..We iterate through number with nested loops
            //They start from one because every number multiplied by zero is zero

            for (int i = 1; i <= thirdDigit; i++)
            {
                for (int x = 1; x <= secondDigit; x++)
                {
                    for (int j = 1; j <= firstDigit; j++)
                    {
                        //Now we should just multiply the numbers we found
                        var result = i * j * x;

                        Console.WriteLine("{0} * {1} * {2} = {3};",
                            i, x, j, result);
                    }
                }
            }

            //Just to mention
            //When i first uploaded that solution to judge it gave me 0/100 because i missed a semicolon
            //Don't miss a semicolon!!
            //That's programmer's worst nightmare!!!! :'(
        }
    }
}
