using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Synchronization.UI
{
    public interface IRailTicketBookingApp
    {
        public void TicketBooking(string name,int value);
        public void BookTicket(string name,int wantedTickets);
    }
}
