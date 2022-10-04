using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithUnitTest
{
    public class MathFunctions
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Addition(double[] nums)
        {
            double sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Subtraction(double[] nums)
        {
            double sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum -= nums[i];
            }

            return sum;
        }

        public static double Multiply(double num1, double num2)
        {
            double sum;

            try
            {
                sum = num1 * num2;
            }
            catch (OverflowException)
            {

                throw new Exception("CAN'T DO THAT MATE!");
            }
            
            
            return sum;
            //return num1 * num2;
        }

        public static decimal? Division(decimal num1, decimal num2)
        {
            decimal result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" The denominator can't be a zero (0). Try again!");
                return null;
            }

            return result;
        }
    }
}
