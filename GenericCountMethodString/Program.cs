using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            string value = Console.ReadLine();
            

            Console.WriteLine(Box<string>.ElementsValueCheck(list, value));
        }
    }
}