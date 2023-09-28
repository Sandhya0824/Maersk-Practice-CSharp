using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadInterCommunication
{
    public class Order : IOrder
    {
        public void GetOrder()
        {
            lock(Program._lock)
            {
                Console.WriteLine("Received the order");
                Monitor.Pulse(Program._lock);
            }
            
        }
    }
}
