using System.Globalization;

namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                list.Add(input);
            }
            double value = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);


            Console.WriteLine(Box<double>.ElementsValueCheck(list, value));
        }
    }
}