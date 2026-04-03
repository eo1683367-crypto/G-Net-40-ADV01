using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints
{
    public class ConstrainClass<T> where T : class
    {
        private T? _cachedItem;

        public T? Get() => _cachedItem;

        public void Set(T item)
        {
            _cachedItem = item;
        }

        public void Clear()
        {
            _cachedItem = null; // ✅ Allowed because T is class
        }
    }
}
