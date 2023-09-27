using DeadlockHandling;

namespace Deadlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            IAccount account1 = new Account(1001, 5000);
            IAccount account2 = new Account(3001, 6000);

            IAccountManager accountManager1 = new AccountManager2(account1, account2, 500);
            Thread thread1 = new Thread(accountManager1.FundTransfer)
            {
                Name="Account1"
            };

            IAccountManager accountManager2=new AccountManager2(account1 , account2, 900);
            Thread thread2 = new Thread(accountManager2.FundTransfer)
            {
                Name="Account2"
            };

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main Thread Completed");
        }
    }
}