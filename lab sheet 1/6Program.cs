namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentname;
            int marks;
            char grade;


            Console.WriteLine("Enter the student's name: ");
            studentname = Console.ReadLine();

            Console.WriteLine("Enter the student's marks: ");
            marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine(" The marks should be between 0 and 100 ");
            }
            else
            {
                if (marks >= 75)
                {
                    grade = 'A';
                }
                else if (marks >= 60)
                {
                    grade = 'B';
                }
                else if (marks >= 50)
                {
                    grade = 'C';
                }
                else if (marks >= 40)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }

                Console.WriteLine(studentname + "'s" + " Grade is " + grade);
                Console.ReadKey();
            }

        }
    }
}
