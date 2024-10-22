using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static double DivideNumbers(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return numerator / denominator;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                double numerator = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                double denominator = Convert.ToDouble(Console.ReadLine());

                double result = DivideNumbers(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is error: " + ex.Message);
            }
        }
    }
}
