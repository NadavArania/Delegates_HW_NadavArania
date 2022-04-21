using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_HW_NadavArania
{
    public class SimpleCalculator
    {
        public int NumberGetter()
        {
            Console.WriteLine("Please enter a positive number!");
            int userNum = int.Parse(Console.ReadLine());
            while (userNum < 0)
            {
                Console.WriteLine("Please try again!");
                userNum = int.Parse(Console.ReadLine());
            }
            return userNum;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Your option of calculation : Plus, Minus, Multiply, Division");
        }

        public int GetUserChoice()
        {
            Console.WriteLine("Please enter a positive number betwen 1-4!");
            int userNum = int.Parse(Console.ReadLine());
            while (userNum < 0 || userNum > 4)
            {
                Console.WriteLine("Please try again!");
                userNum = int.Parse(Console.ReadLine());
            }
            return userNum;
        }

        public double Calculate(int num1, int num2, int num3)
        {
            if(num3 == 1)
            {
                double plus = num1 + num2;
                return plus;
            }
            else if(num3 == 2)
            {
                double minus = num1 - num2;
                return minus;
            }
            else if(num3 == 3)
            {
                double multiply = num1 * num2;
                return multiply;
            }
            else
            {
                double divsion = num1 / num2;
                return divsion;
            }
        }

        public void PrintResultNicely(double result)
        {
            Console.WriteLine($"*{result}*");
        }
    }
}
