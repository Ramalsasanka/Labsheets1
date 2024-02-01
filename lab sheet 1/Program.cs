namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area;
            Console.WriteLine("Enter the length");
            double length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            double Width = int.Parse(Console.ReadLine());
            Area = length * Width;
            Console.WriteLine("The area is " + Area);
            Console.ReadKey();

        }
    }
}
