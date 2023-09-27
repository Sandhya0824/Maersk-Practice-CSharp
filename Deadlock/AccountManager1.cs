using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    public class AccountManager1 : IAccountManager
    {
        private IAccount _fromAccount;
        private IAccount _toAccount;
        private double _transferAmount;

        public AccountManager1(IAccount fromAccount, IAccount toAccount, double amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _transferAmount = amount;
        }

        public void FundTransfer()
        {
            Console.WriteLine("{0} trying to aquire lock on {1}", Thread.CurrentThread.Name, _fromAccount.Id);

            lock (_fromAccount)
            {
                
                Console.WriteLine("{0} Processing Some work", Thread.CurrentThread.Name);
                Console.WriteLine("{0} trying to acquire lock on {1}", Thread.CurrentThread.Name, _toAccount.Id);

                if (Monitor.TryEnter(_toAccount, 2000))
                {
                    Console.WriteLine("{0} acquired lock on {1}",Thread.CurrentThread.Name, _toAccount.Id);

                    try
                    {
                        _fromAccount.Withdraw(_transferAmount);
                        _toAccount.Deposit(_transferAmount);
                    }
                    finally
                    {
                        Monitor.Exit(_toAccount);
                    }
                }
                else
                {
                    Console.WriteLine("{0} unable to acquire lock on {1}", Thread.CurrentThread.Name, _toAccount.Id);
                }
            }
        }
    }
}
