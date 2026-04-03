using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Genaric_Method
{
    public static class Utilities
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //-----------------------------------------------------------------------

        public static T FindMaxValue<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];

            foreach (var item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
