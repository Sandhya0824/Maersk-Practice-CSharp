using Deadlock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlockHandling
{
    public class AccountManager2 : IAccountManager
    {
        private IAccount _fromAccount;
        private IAccount _toAccount;
        private double _transferAmount;

        public AccountManager2(IAccount fromAccount, IAccount toAccount, double amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _transferAmount = amount;
        }

        public void FundTransfer()
        {
            object _lock1, _lock2;

            if (_fromAccount.Id < _toAccount.Id)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }

            Console.WriteLine("{0} trying to acquire lock on{1}", Thread.CurrentThread.Name, ((IAccount)_lock1).Id);

            lock (_lock1)
            {
                Console.WriteLine("{0} acquired lock on{1}", Thread.CurrentThread.Name, ((IAccount)_lock1).Id);
                Console.WriteLine("{0} Processing Work", Thread.CurrentThread.Name);
                Console.WriteLine("{0} trying to acquire lock on{1}", Thread.CurrentThread.Name, ((IAccount)_lock2).Id);

                lock(_lock2)
                {
                    Console.WriteLine("{0} acquired lock on{1}", Thread.CurrentThread.Name, ((IAccount)_lock2).Id);
                    _fromAccount.Withdraw(_transferAmount);
                    _toAccount.Deposit(_transferAmount);
                }
            }
        }
    }
}
