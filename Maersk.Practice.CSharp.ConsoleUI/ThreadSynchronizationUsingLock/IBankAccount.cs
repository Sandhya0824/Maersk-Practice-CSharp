using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.ThreadSynchronizationUsingLock
{
    public interface IBankAccount
    {
        public decimal GetBalance();
        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
    }
}
