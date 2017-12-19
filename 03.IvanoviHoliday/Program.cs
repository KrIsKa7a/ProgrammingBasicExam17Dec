using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IvanoviHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            //We read all the input just like in every problem we solute
            var nightsCount = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var transport = Console.ReadLine();

            //Here we declare the variables we will need to use after the check
            var toPayPerAdult = 0.0;
            var toPayPerKid = 0.0;

            //Here we check
            if (destination == "Miami")
            {
                if (nightsCount >= 1 && nightsCount <= 10)
                {
                    toPayPerAdult = 24.99;
                    toPayPerKid = 14.99;
                }
                else if (nightsCount >= 11 && nightsCount <= 15)
                {
                    toPayPerAdult = 22.99;
                    toPayPerKid = 11.99;
                }
                else
                {
                    toPayPerAdult = 20.00;
                    toPayPerKid = 10.00;
                }
            }
            else if (destination == "Canary Islands")
            {
                if (nightsCount >= 1 && nightsCount <= 10)
                {
                    toPayPerAdult = 32.50;
                    toPayPerKid = 28.50;
                }
                else if (nightsCount >= 11 && nightsCount <= 15)
                {
                    toPayPerAdult = 30.50;
                    toPayPerKid = 25.60;
                }
                else
                {
                    toPayPerAdult = 28.00;
                    toPayPerKid = 22.00;
                }
            }
            else
            {
                if (nightsCount >= 1 && nightsCount <= 10)
                {
                    toPayPerAdult = 42.99;
                    toPayPerKid = 39.99;
                }
                else if (nightsCount >= 11 && nightsCount <= 15)
                {
                    toPayPerAdult = 41.00;
                    toPayPerKid = 36.00;
                }
                else
                {
                    toPayPerAdult = 38.50;
                    toPayPerKid = 32.40;
                }
            }

            //Okey..Up to here we have the price per adult and the price per kid
            //We said the price for hotel is the equation below:
            //You can find it in the document with the problem in examples section
            var toPayforHotel = (nightsCount * (2 * toPayPerAdult + 3 * toPayPerKid));

            //We have a dog don't forget :)
            toPayforHotel += 0.25 * toPayforHotel;


            //Here we need to do just one more check
            //They said that we will have to pay for transport
            var toPayPerAdultForTransport = 0.0;
            var toPayPerKidForTransport = 0.0;

            if (transport == "train")
            {
                toPayPerAdultForTransport = 22.30;
                toPayPerKidForTransport = 12.50;
            }
            else if (transport == "bus")
            {
                toPayPerAdultForTransport = 45.00;
                toPayPerKidForTransport = 37.00;
            }
            else
            {
                toPayPerAdultForTransport = 90.00;
                toPayPerKidForTransport = 68.50;
            }

            //Here we calculate the money for transport for whole family
            var transportSpents = (2 * toPayPerAdultForTransport) + (3 * toPayPerKidForTransport);

            //And we just need to calculate the money they should spent for whole holiday
            var totalMoneyNeeded = toPayforHotel + transportSpents;

            //Don't forget to format it up to three digits after float delimiter
            Console.WriteLine("{0:f3}", totalMoneyNeeded);
        }
    }
}
