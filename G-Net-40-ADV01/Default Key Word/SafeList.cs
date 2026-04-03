using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Default_Key_Word
{
    internal class SafeList<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item) => _items.Add(item);

        public T? GetValueAt(int index) => index >= 0 && index < _items.Count ? _items[index] : default(T);
    }
}
