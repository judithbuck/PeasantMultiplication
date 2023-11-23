using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            List<int> nums = new List<int>();
            Console.WriteLine($"{num1} * {num2}");
            do
            {
                if (num2 % 2 != 0)
                {
                    nums.Add(num1);
                }
                num1 *= 2;
                num2 /= 2;

                Console.WriteLine($"{num1} * {num2} {adders(nums)}");
            } while (num2 > 1);
            Console.WriteLine($"The answer is {num1 * num2 + nums.Sum()}");
        }
        static string adders(List<int> nums)
        {
            string output = " + ";
            if (nums.Count == 0)
            {
                return "";
            }
            for (int i = 0; i < nums.Count-1; i++)
            {
                output += nums[i].ToString() + " + ";
            }
            output += nums[nums.Count - 1].ToString();
            return output;
        }
    }
}
