namespace Maersk.Practice.ThreadClass.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IParameterLessMethod parameterLessMethod = new ParameterLessMethod();
            //ThreadStart threadStart = new ThreadStart(parameterLessMethod.Display);
            //Thread thread1 = new Thread(threadStart);
            Thread thread1 = new Thread(new ThreadStart(parameterLessMethod.Display));
            thread1.Start();

            //Anonymous Function
            Thread thread3 = new Thread(
                    delegate()
                    {
                        Console.WriteLine("Hello! Welcome to Maersk => Anonymous Function");
                    }
                );
             thread3.Start();

            //Lambda Expression
            Thread thread4 = new Thread(() =>
                    {
                        Console.WriteLine("Welcome to Maersk. => Lambda Expression");
                    }
                );
            thread4.Start();

            //Type Unsafe Parameterized Method
            IParameterizedMethod parameterizedMethod = new ParameterizedMethod();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(parameterizedMethod.DisplayMessage);
            Thread thread2 = new Thread(parameterizedThreadStart);
            thread2.Start("Welcome to Bangalore GSC");

            //Anonymous Function
            IParameterizedMethod parameterizedMethod1 = new ParameterizedMethod();
            Thread thread5 = new Thread(
                    delegate ()
                    {
                        parameterizedMethod1.DisplayMessage("Welcome to Bangalore GSC  => Anonymous Function");
                    }
                );
            thread5.Start();

            IParameterizedMethod parameterizedMethod2 = new ParameterizedMethod();
            Thread thread6 = new Thread(() =>
                {
                    parameterizedMethod2.DisplayMessage("Welcome to Bangalore GSC  =>  Lambda Expression");
                }
            );
            thread6.Start();

            //Type Safe Parameterized Method
            IParameterizedMethodTypeSafe parameterizedMethodTypeSafe = new ParameterizedMethodTypeSafe("Rohan", "I'm the Manager here.");
            Thread thread7=new Thread(new ThreadStart(parameterizedMethodTypeSafe.DisplayMessage));
            thread7.Start();

            //Anonymous Function
            IParameterizedMethodTypeSafe parameterizedMethodTypeSafe1 = new ParameterizedMethodTypeSafe("Rohan", "I'm the Manager here.");
            Thread thread8 = new Thread(
                delegate ()
                {
                    parameterizedMethodTypeSafe1.DisplayMessage();
                }
            );
            thread8.Start();

            //Lambda Function
            IParameterizedMethodTypeSafe parameterizedMethodTypeSafe3 = new ParameterizedMethodTypeSafe("Rohan", "I'm the Manager here.");
            Thread thread9 = new Thread(() =>
            {
                parameterizedMethodTypeSafe3.DisplayMessage();
            });
            thread9.Start();
        }
    }
}