using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints.New__
{
    internal class People
    {
        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public People()
        {
            // to make the instance of People use the ConstrainParameterlessConstructor
            // because ConstrainParameterlessConstructor  have parameterless constrain:
            // ConstrainParameterlessConstructor<T> where T : new()
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Id} ::: {Name}";
        

    }
}
