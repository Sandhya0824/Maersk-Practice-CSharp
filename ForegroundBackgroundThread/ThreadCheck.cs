using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForegroundBackgroundThread
{
    public class ThreadCheck : IThreadCheck
    {
        private int _maxCount;
        public ThreadCheck(int maxCount)
        {
            _maxCount = maxCount;
        }
        public void Task()
        {
            for(int i=0;i < _maxCount; i++)
            {
                Console.WriteLine("{0} Count: {1}", Thread.CurrentThread.IsBackground ? "Background Thread" : "Foreground Thread", i);
                Thread.Sleep(1);
            }
            Console.WriteLine("{0} Finished.", Thread.CurrentThread.IsBackground ? "Background Thread" : "Foreground Thread");

        }
    }
}
