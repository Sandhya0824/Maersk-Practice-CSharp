using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    interface IVehicle
    {
        void changeGear();
        void speedUp(int x);
        void applyBreaks(int x);
    }

    class Car : IVehicle
    {
        int gear, speed;

        public void changeGear()
        {
            gear++;
        }

        public void speedUp(int x)
        {
            speed += x;
        }

        public void applyBreaks(int x)
        {
            speed -= x;
        }

        public void displayResults()
        {
            Console.WriteLine("Gear Changes : " + gear + " Speed : " + speed);
        }
    }
    internal class InterfacePractice
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.changeGear();
            car.speedUp(1);
            car.applyBreaks(1);
            car.changeGear();
            car.speedUp(2);
            car.displayResults();
        }
    }
}
