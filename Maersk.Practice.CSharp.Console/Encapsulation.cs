using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    public class BankAccount
    {
        private static double _balance;

        public BankAccount() { }
        public BankAccount(double balance) 
        {
            _balance = balance;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance > amount)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        public double GetBalance() { return _balance;}

    }
    internal class Encapsulation
    {
        public static void Main(string[] args)
        {
            BankAccount bankAccount=new BankAccount(50000);
            bankAccount.Deposit(500);
            Console.WriteLine("Balance = " + bankAccount.GetBalance());
            bankAccount.Withdraw(100);
            Console.WriteLine("Balance = " + bankAccount.GetBalance());
        }
    }
}
