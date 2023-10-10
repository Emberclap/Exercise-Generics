namespace GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                int text = int.Parse(Console.ReadLine());
                Box<int> generic = new Box<int>(text);
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