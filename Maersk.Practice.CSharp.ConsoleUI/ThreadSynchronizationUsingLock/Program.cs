using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.ThreadSynchronizationUsingLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);

            Thread thread1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    account.Deposit(100);
                    Thread.Sleep(100);
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    account.Withdraw(200);
                    Thread.Sleep(150);
                }
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Final Balance: {account.GetBalance()}");
        }
    }
}
