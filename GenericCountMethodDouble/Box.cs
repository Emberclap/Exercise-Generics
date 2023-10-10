using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private T value;


        public Box(T value)
        {
            this.value = value;

        }

        public static int ElementsValueCheck(List<T> list, T type)
        {
            int counter = 0;
            foreach (var element in list)
            {
                if (type.CompareTo(element) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
