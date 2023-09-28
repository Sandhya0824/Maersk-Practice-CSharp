namespace ThreadInterCommunication
{
    internal class Program
    {
        public static readonly object _lock = new object();
        static void Main(string[] args)
        {
            ICooking cooking = new Cooking();
            IOrder order = new Order();

            Thread thread1 = new Thread(cooking.StartCooking)
            {

            };
            thread1.Start();

            Thread thread = new Thread(order.GetOrder)
            {

            }; 
            thread.Start();

            
            
        }
    }
}