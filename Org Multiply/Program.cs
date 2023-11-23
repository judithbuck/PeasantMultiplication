//.NET 6.0, 'Do not use top level statements' selected
namespace Org_Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first (integer) number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num1start = num1;
            Console.WriteLine("Enter your second (integer) number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num2start = num2;
            Console.WriteLine("Your two numbers are " + num1 + " and " + num2);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            int sum = 0;

            while (num2 > 0) 
            {
                if (num2 % 2 == 1) 
                {
                    sum += num1;
                }
                num1 = 2 * num1;
                num2 /= 2;
                Console.WriteLine("Your two numbers are " + num1 + " and " + num2+ ": The sum is " + sum);
                //Console.WriteLine("The sum is " + sum);
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
            }
            Console.WriteLine("Answer " + num1start+" x " + num2start + " = " + sum);
            Console.WriteLine("Press any key to end ...");
            Console.ReadKey();
        }
    }
}