using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints.Interface_Constrain
{
    class Sorter<T> where T : IComparable<T>
    {
        public T[] Sort(T[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
