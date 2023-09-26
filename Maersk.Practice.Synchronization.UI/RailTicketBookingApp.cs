using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Synchronization.UI
{
    public class RailTicketBookingApp : IRailTicketBookingApp
    {
        private object _lockObject = new object();
        private int _totalAvailableTickets;

        public RailTicketBookingApp(int totalAvailableTickets)
        {
            _totalAvailableTickets = totalAvailableTickets;
        }

        public void BookTicket(string name, int wantedTickets)
        {
            lock(_lockObject)
            {
                if(wantedTickets<=_totalAvailableTickets)
                {
                    Console.WriteLine("{0} booked {1} tickets.",name, wantedTickets);
                    _totalAvailableTickets= _totalAvailableTickets - wantedTickets;
                }
                else
                {
                    Console.WriteLine("Can't book the tickets for {0}",name);
                }
            }
        }

        public void TicketBooking(string name,int value)
        {
          BookTicket(name,value);
        }
    }
}
