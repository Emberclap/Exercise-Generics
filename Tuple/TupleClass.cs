using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class TupleClass<T, T2>
    {
        public TupleClass(T item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;

        }

        public T Item1 { get; set; }
        public T2 Item2 { get; set;}

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
