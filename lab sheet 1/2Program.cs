namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int number;
            int count = 0;
            while (count < 10)
            {

                Console.WriteLine("Enter number {0}:", count + 1);
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
                count++;
                Console.ReadKey();
            }
        }
    }
}
