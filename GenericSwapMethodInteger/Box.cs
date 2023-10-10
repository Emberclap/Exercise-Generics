using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }


        public override string ToString()
        {
            return ($"{value.GetType()}: {value}");
        }
        public static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
