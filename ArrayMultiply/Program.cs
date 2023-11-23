//Windows only console app - .NET 4.7.2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input two numbers to multiply
            Console.WriteLine("Enter your first (integer) number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second (integer) number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // save starting numbers
            int num1start = num1;
            int num2start = num2;
            // output user input
            Console.WriteLine("You entered " + num1 + " and " + num2);
            // for calculation and calc history
            int sum = 0;
            int sum0 = 0;
            // double first user number and halve second
            while (num2 > 0)
            {
                //when second user no is odd - increment sum by last doubled number (num1)
                if (num2 % 2 == 1)
                {
                    sum0 = sum;
                    sum += num1;
                    Console.WriteLine("Your two numbers are: " + num1 + " and " + num2 + ", num2 is odd - The sum has changed " + sum0 + " (sum) + " + num1 + " (num1) = " + sum);

                }
                //when second user no is even - sum is unchanged
                else
                {
                    Console.WriteLine("Your two numbers are: " + num1 + " and " + num2 + ", num2 is even - therefore the sum is still " + sum);
                }
                num1 = 2 * num1;
                num2 /= 2;
            }
            // num 2 is zero, answer is value of 'sum'
            Console.WriteLine("Answer: " + num1start + " x " + num2start + " = "+ sum);
            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
