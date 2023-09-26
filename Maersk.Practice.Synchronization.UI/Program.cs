namespace Maersk.Practice.Synchronization.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRailTicketBookingApp app = new RailTicketBookingApp(15);
            Thread thread1 = new Thread(()=> app.TicketBooking("Person1",5))
            {
                Name = "Person 1"
            };

            Thread thread2 = new Thread(() => app.TicketBooking("Person2", 6))
            {
                Name = "Person 2"
            };

            Thread thread3 = new Thread(() => app.TicketBooking("Person3", 9))
            {
                Name = "Person 3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }

}