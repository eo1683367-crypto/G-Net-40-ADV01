using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints.Base_Class_Constrain
{
    internal class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }
        public Cat()
        {

        }
        public override string speake() => "Meow";

    }
}
