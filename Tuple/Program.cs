using System.Globalization;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bearTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numbersTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            TupleClass<string, string> personAddress = new ($"{personTokens[0]} {personTokens[1]}", personTokens[2]);
            TupleClass<string, int> bearInfo = new(bearTokens[0], int.Parse(bearTokens[1]));
            TupleClass<int, double> numbersInfo = new(int.Parse(numbersTokens[0]),
                double.Parse(numbersTokens[1], System.Globalization. CultureInfo.InvariantCulture));

            Console.WriteLine(personAddress);
            Console.WriteLine(bearInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}