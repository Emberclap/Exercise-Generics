namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {   
                int text = int.Parse(Console.ReadLine());
                box.ToString(text);
                
            }
        }
    }
}