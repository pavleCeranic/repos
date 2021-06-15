using System;
using System.Collections;
using static System.Console;
using ConsoleApp1.Functions;


namespace ConsoleApp1
{
    class Program
    {
        /*
        static void TimesTable(int number)
        {
            WriteLine($"This is the {number} Times Table: ");

            for(int row = 1; row <= number; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }

            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255:");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }

            while (isNumber);
        }

        */

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": //Switzerland
                    rate = 0.08M;
                    break;
                case  "DK":   //Denmark
                case  "NO":   //Norway
                    rate = 0.25M;
                    break;
                case "UK": //UNITED KINGDOM
                case "FR": //France
                    rate = 0.2M;
                    break;
                case "HU": //Hungary
                    rate = 0.27M;
                    break;
                case "OR": //Oregon
                case "AK": //Alaska
                case "MT": //Montana
                    rate = 0.05M;
                    break;
                case "ND": //North Dakota
                case "WI": //Wiscosin
                case "ME": //Maryland
                case "VA": //Virginia
                    rate = 0.05M;
                    break;
                case "CA": //California
                    rate = 0.0825M;
                    break;
                default:  //most US states
                    rate = 0.06M;
                    break;

            }
            return amount * rate;
        }


        


        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{function.CardinalToOrdinal(number)}");
            }
            WriteLine();
        }


        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();

            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }


                    static void Main(string[] args)
        {
            //RunTimesTable();
            //RunCalculateTax();
            //RunCardinalToOrdinal();
            factorial.RunFactorial();
        }
    }
}
