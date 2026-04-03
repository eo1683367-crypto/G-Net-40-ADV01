using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Final_Exercise_Q20
{

    // ===== CacheItem =====
   public class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsExpired => DateTime.Now > ExpiresAt; // Computed property 
    }
}
