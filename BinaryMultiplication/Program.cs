//.NET 6.0, 'Do not use top level statements' selected
// <ImplicitUsings>disable</ImplicitUsings> in *.csproj file
// ref https://dotnettutorials.net/lesson/decimal-to-binary-conversion-in-csharp/
using System;

namespace BinaryMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first multiplicand - convert to binary
            Console.Write("Enter the Decimal Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            // second multiplicand - double
            Console.Write("Enter second multiplicand : ");
            int no = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            // highest/last position of i
            int j = i;

//            Console.Write("Binary Represenation of the given Number : ");
//            for (i = i - 1; i >= 0; i--)
//            {
//                Console.Write(numberArray[i]);
//           }

            // second multiplicand - double
            int sum = 0;
            Console.Write("Answer : ");
            for (i = 0; i < j; i++)
            {
                sum += numberArray[i] * no;
                no = no * 2;
            }
            
            Console.Write(sum.ToString());
            Console.ReadKey();

        }
    }
}