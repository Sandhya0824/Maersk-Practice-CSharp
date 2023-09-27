using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.MonitorIsAlivePulse.UI
{
    public class EvenPrinter : IEvenPrinter
    {

        public void DisplayEvenNumbers()
        {
            
            try
            {
                Monitor.Enter(Program._lockObject);
                for(int i = 0; i <= Program.numberLimit; i+=2)
                {
                    Console.WriteLine(i);
                    Monitor.Pulse(Program._lockObject);

                    bool isLast = false;
                    if (i == Program.numberLimit)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(Program._lockObject);
                    }
                }
            }
            finally
            {
                Monitor.Exit(Program._lockObject);
            }
        }
    }
}
