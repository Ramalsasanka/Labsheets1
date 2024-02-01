using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("Enter a positive integer");
            number = int.Parse(Console.ReadLine());
            if (number<0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i=1;i<=number;i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of numbers from 1 to {0} is {1}.", number, sum);
                Console.ReadKey();
            }
        }
    }
}
