namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first N terms for Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i) + " ");
            }

            Console.ReadLine(); 
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            Console.ReadKey();
        }
    }
}
