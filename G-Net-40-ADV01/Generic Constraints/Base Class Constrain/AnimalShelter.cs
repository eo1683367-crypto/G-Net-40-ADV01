using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Generic_Constraints.Base_Class_Constrain
{
    internal class AnimalShelter<T> where T : Animal
    {

        private readonly List<T> _animals = [];

        public void AddAnimal(T animal) => _animals.Add(animal);

        public void MakeSound()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"{animal.Name} ::: {animal.speake()}");
            }
        }
    }
}
