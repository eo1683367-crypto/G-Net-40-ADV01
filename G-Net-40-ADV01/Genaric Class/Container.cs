using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Genaric_Class
{
    internal class Container<T>
    {
        #region Attributes
        private List<T> _items = new List<T>();
      

        public int Count => _items.Count;
        #endregion

        #region Methods
        public void Add(T item) =>_items.Add(item);
        public T? Get(int index) => index >= 0 && index < Count ? _items[index] : default(T); 
        #endregion

    }
}
