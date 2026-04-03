using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints
{
    internal class ConstrainParameterlessConstructor<T> where T : new()
    {
        public T Create()
        {
            return new T(); // ✅ Allowed because of new() constraint
        }

    }
}
