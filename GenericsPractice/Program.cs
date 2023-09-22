using Maersk.Practice.Generics.UI;

namespace GenericsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyDataStructure<int> myDataStructure = new MyDataStructure<int>();
            myDataStructure.Add(1);
            myDataStructure.Add(2);
            myDataStructure.Add(3);

            Console.WriteLine(myDataStructure.Count());

            myDataStructure.Display();
        }
    }
}