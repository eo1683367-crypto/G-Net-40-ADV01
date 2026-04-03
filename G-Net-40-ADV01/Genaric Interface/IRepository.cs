using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Genaric_Interface
{
    internal interface  IRepository<T>
    {

        List<T> GetAll();

        T GetById(int id);

        void Delete(T item);

        void Add(T item);

        T Update(T item);
    }
}
