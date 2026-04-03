using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints
{
    internal class ConstraintStruct<T> where T : struct
    {
            public T Value { get; set; }
            public bool HasValue => !Value.Equals(default(T));
       
    }
}
