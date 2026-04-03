using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Pair_Genaic_Class
{
    internal class Employee<T1,T2>
    {
        #region Attribute
        public T1 Id { get; set; }

        public T2 Name { get; set; }
        #endregion

        #region Consrtuctor
        public Employee(T1 id, T2 name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Method
        public override string ToString() => $"Employee-Id : {Id} ::: Employee-Name : {Name}"; 
        #endregion

    }
}
