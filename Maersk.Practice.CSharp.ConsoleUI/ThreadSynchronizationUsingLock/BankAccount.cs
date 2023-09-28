using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.ThreadSynchronizationUsingLock
{
    internal class BankAccount : IBankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            lock (this) 
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }
        }

        public void Withdraw(decimal amount)
        {
            lock (this) 
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}, New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
        }
    }
}
