namespace ThreadLifeCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMethod method = new Method();

            try
            {
                Thread thread = new Thread(method.Task)
                {
                    Name = "Thread1"
                };

                Console.WriteLine("Before Start: IsAlive: {0}, Thread State: {1}", thread.IsAlive, thread.ThreadState);

                thread.Start();
                Console.WriteLine("After Start: IsAlive: {0}, Thread State: {1}", thread.IsAlive, thread.ThreadState);

                thread.Suspend();
                Console.WriteLine("After Suspend: IsAlive: {0}, Thread State: {1}", thread.IsAlive, thread.ThreadState);

                thread.Resume();
                Console.WriteLine("After Resume: IsAlive: {0}, Thread State: {1}", thread.IsAlive, thread.ThreadState);

                thread.Abort();
                Console.WriteLine("After Abort: IsAlive: {0}, Thread State: {1}", thread.IsAlive, thread.ThreadState);

                thread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0}",ex.ToString());
            }
        }
    }
}   