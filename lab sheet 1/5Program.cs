namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
             int number =int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication table for " + number + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }

            Console.ReadKey();
        }
    }

}
    

