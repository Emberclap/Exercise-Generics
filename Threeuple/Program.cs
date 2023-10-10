namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] beerTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numbersTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            TupleClass<string, string, string> personAddress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], personTokens[3]);
            TupleClass<string, int, bool> bearInfo = new(beerTokens[0], int.Parse(beerTokens[1]), IsDrunk(beerTokens[2]));
            TupleClass<string, double, string> numbersInfo = new(numbersTokens[0], double.Parse(numbersTokens[1], 
                System.Globalization.CultureInfo.InvariantCulture), numbersTokens[2]);

            Console.WriteLine(personAddress);
            Console.WriteLine(bearInfo);
            Console.WriteLine(numbersInfo);
        }
        public static bool IsDrunk(string input)
        {
            if (input == "drunk")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}