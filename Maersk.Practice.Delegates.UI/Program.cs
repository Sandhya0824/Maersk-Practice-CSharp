namespace Maersk.Practice.Delegates.UI
{
    delegate double Calculate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            Calculate addition = calculator.Add;
            Calculate subtraction = calculator.Subtract;
            Calculate multiplication = calculator.Multiply;

            double additionResult = addition(5, 6);
            double subtractionResult = subtraction(5, 6);
            double multiplicationResult = multiplication(5, 6);

            Console.WriteLine("Addition: {0}, Subtraction: {1}, Multiplication: {2}",additionResult,subtractionResult,multiplicationResult);
        }
    }
}