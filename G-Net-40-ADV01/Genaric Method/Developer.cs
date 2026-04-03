using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Genaric_Class
{
    internal class Developer : IComparable<Developer>
    {
        //constructor
        public Developer(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        //Attributes
        public string Name { get; set; }

        public decimal Salary { get; set; }

        //Implement The Interface of :((IComparable<Developer>))
        public int CompareTo(Developer other) => this.Salary > other.Salary ? 1 : -1;      

        //
        public override string ToString() => $"Dev-Name : {Name} ::: Dev-Salary : {Salary}";

        
    }
}
