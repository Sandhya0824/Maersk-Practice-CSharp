using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadInterCommunication
{
    public class Cooking : ICooking
    {
        public void StartCooking()
        {
            lock (Program._lock)
            {
                Monitor.Wait(Program._lock);

                Console.WriteLine("Chef started cooking");
                Thread.Sleep(1000);
                Console.WriteLine("Order Prepared");
            }
            
        }
    }
}
