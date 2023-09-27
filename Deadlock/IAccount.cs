using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    public interface IAccount
    {
        public int Id { get; set; }
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
