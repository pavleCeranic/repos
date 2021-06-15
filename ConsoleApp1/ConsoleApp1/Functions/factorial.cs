using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp1.Functions
{
    class factorial
    {
        static int Factorial(int number)
        {
            if(number<1)
            {
                return 0;
            }
            else if(number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number:  ");

                isNumber = int.TryParse(
                    ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine($"You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
    }
}
