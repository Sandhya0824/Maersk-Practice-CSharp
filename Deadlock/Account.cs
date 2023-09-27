using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    public class Account : IAccount
    {
        public int Id { get; set; }
        private double _balance { get; set; }

        public Account(int id, double balance)
        {
            Id = id;
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
        }
    }
}
