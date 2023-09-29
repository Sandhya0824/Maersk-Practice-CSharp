using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class SemaphoreExample
    {
        static Semaphore parkingLot = new Semaphore(5, 5);

        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread carThread = new Thread(ParkCar);
                carThread.Start(i);
            }
        }

        static void ParkCar(object carId)
        {
            int id = (int)carId;
            Console.WriteLine($"Car {id} is approaching the parking lot.");
            parkingLot.WaitOne();
            Console.WriteLine($"Car {id} has parked in a spot.");
            Thread.Sleep(2000);
            Console.WriteLine($"Car {id} is leaving the parking lot.");

            parkingLot.Release();
        }
    }
}
