using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestsCount = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());

            //We need to find the money for couverts and if they are less than the budget
            var moneyCollected = guestsCount * 20;

            //Here we check that
            if (moneyCollected <= budget)
            {
                //Here we should calculate money left
                var moneyLeft = budget - moneyCollected;

                //We need to calculate the money for fireworks
                var fireworksMoney = moneyLeft * 0.40;

                //And the left money from the moneyLeft are for donations
                var moneyForDonations = moneyLeft - fireworksMoney;

                //Now we should print the expected output using placeholders
                //Also we should have only numbers with 0 decimal digits after float delimiter
                Console.WriteLine($"Yes! {fireworksMoney:f0} lv are for fireworks and {moneyForDonations:f0} lv are for donation.");
            }
            else
            {
                //Here we just need to calculate the money they should pay
                var moneyToPay = moneyCollected - budget;

                //And we just print them
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {moneyToPay:f0} lv more.");
            }
        }
    }
}
