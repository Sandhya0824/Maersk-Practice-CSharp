using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.MonitorIsAlivePulse.UI
{
    public class OddPrinter : IOddPrinter
    {

        public void DisplayOddNumbers()
        {
            try
            {
                Monitor.Enter(Program._lockObject);

                for (int i = 1; i <= Program.numberLimit; i += 2)
                {
                    Console.WriteLine(i);
                    Monitor.Pulse(Program._lockObject);

                    bool isLast = false;
                    if(i == Program.numberLimit - 1)
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
