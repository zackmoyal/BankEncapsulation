using System.Runtime.CompilerServices;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Get Balance");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the amount to deposit: ");
                            double depositAmount;
                            if (double.TryParse(Console.ReadLine(), out depositAmount))
                            {
                                account.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Your balance: ${account.GetBalance()}");
                            break;
                        case 3:
                            Console.WriteLine("Exiting now.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option (1, 2, or 3).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine();
            }
        }
    }
}
