namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 4000;
            int choice;
            int amount;

            do
            {
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Checkbalance(balance);
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        DepositMoney(ref balance, amount);
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw: ");
                        amount = int.Parse(Console.ReadLine());
                        WithdrawMoney(ref balance, amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank you ");
                        break;
                    default:
                        Console.WriteLine(" Please try again.");
                        break;
                }
                
            } while (choice != 4);
        }

        static void Checkbalance(int balance)
        {
            Console.WriteLine("Your current balance is: " + balance);
        }

        static void DepositMoney(ref int balance, int amount)
        {
            balance += amount;
            Console.WriteLine(" Your new balance is: " + balance);
        }

        static void WithdrawMoney(ref int balance, int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance. ");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful. Your new balance is: " + balance);
            }
        }
    }
}
