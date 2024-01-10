using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
        }

        public double GetBalance() 
        {
            return balance;
        }
    }
}
