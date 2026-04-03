using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Final_Exercise_Q20
{
    // ===== Cache =====
   public class Cache<TKey, TValue>
    {
        //
        private List<(TKey Key, CacheItem<TValue> Item)> _list = new();

        // Add
        public void Add(TKey key, TValue value, int seconds)
        {
            _list.Add((key, new CacheItem<TValue>
            {
                Value = value,
                ExpiresAt = DateTime.Now.AddSeconds(seconds)
            }));
            Console.WriteLine($"Added: {key} = {value}");
        }

        // Get
        public TValue Get(TKey key)
        {
            foreach (var item in _list)
            {
                if (item.Key.Equals(key))
                {
                    if (item.Item.IsExpired)
                    {
                        Console.WriteLine($"{key} => Expired!");
                        return default;
                    }
                    Console.WriteLine($"{key} => {item.Item.Value}");
                    return item.Item.Value;
                }
            }
            Console.WriteLine($"{key} => Not Found!");
            return default;
        }

        // Remove
        public void Remove(TKey key)
        {
            _list.RemoveAll(e => e.Key.Equals(key));
            Console.WriteLine($"Removed: {key}");
        }

        // Contains
        public bool Contains(TKey key)
        {
            foreach (var entry in _list)
                if (entry.Key.Equals(key) && !entry.Item.IsExpired)
                    return true;
            return false;
        }
    }
}
