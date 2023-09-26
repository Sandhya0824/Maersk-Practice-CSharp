namespace Maersk.Practice.RetrieveDataThread.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactorialResult factorialResult = new FactorialResult();
            ResultCallBackDelegate resultCallBackDelegate = new ResultCallBackDelegate(factorialResult.DisplayResult);

            IFactorialCalculator factorialCalculator = new FactorialCalculator(5, resultCallBackDelegate);
            
            Thread factorialThread=new Thread(new ThreadStart(factorialCalculator.CalculateFactorial));
            factorialThread.Start();
        }
    }
}