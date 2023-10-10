using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T value;

        public Box()
        {
            this.value = value;
        }
        

        public void ToString(int value)
        {
            Console.WriteLine($"{value.GetType()}: {value}");
        }
    }
}
