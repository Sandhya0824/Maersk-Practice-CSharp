using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console.Multithreading.ThreadSynchronization
{
    public class BookMyShow
    {
        private object lockObject = new object();
        int AvailableTickets = 3;
        static int i = 1, j = 2, k = 3;
        public void CheckAvailabilityNBookTicket(string name, int wantedtickets)
        {
            lock (lockObject)
            {
                if (wantedtickets <= AvailableTickets)
                {
                    System.Console.WriteLine(wantedtickets + " ticked booked for " + name);
                    AvailableTickets = AvailableTickets - wantedtickets;
                }
                else
                {
                    System.Console.WriteLine("No tickets Available to book");
                }
            }
        }
        public void BookShowTickets()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("User1"))
            {
                CheckAvailabilityNBookTicket(name, i);
            }
            else if (name.Equals("User2"))
            {
                CheckAvailabilityNBookTicket(name, j);
            }
            else
            {
                CheckAvailabilityNBookTicket(name, k);
            }
        }
    }
    public class BookMyShowExample
    {
        static void Main(string[] args)
        {
            BookMyShow bookMyShow = new BookMyShow();
            Thread user1 = new Thread(bookMyShow.BookShowTickets)
            {
                Name = "User1"
            };
            Thread user2 = new Thread(bookMyShow.BookShowTickets)
            {
                Name = "User2"
            };
            Thread user3 = new Thread(bookMyShow.BookShowTickets)
            {
                Name = "User3"
            };

            user1.Start();
            user2.Start();
            user3.Start();
            System.Console.ReadKey();
        }
    }
}
