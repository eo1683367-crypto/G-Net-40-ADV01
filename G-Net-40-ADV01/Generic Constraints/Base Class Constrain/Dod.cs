using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints.Base_Class_Constrain
{
    internal class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }
        public Dog()
        {

        }
        public override string speake() => "Woof";

    }

}
