using GenericBoxOfString;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Box<string> generic = new Box<string>(text);
                list.Add(generic);
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Box<string>.Swap(list, indexes[0], indexes[1]);

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        
        
    }

}