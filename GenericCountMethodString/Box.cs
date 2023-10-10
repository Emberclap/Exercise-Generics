using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GenericCountMethodString
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
       //public override string ToString()
       //{
       //    return ($"{value.GetType()}: {value}");
       //}
       //public static void Swap<T>(List<Box<T>> list, int index1, int index2)
       //{
       //    Box<T> temp = list[index1];
       //    list[index1] = list[index2];
       //    list[index2] = temp;
       //}
    }
    }
