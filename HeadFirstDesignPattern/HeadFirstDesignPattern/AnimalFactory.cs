using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern
{
    class AnimalFactory
    {
        List<Animal> animalList;

        List<Animal> getAnimals()
        {
            if (animalList != null)
                return animalList;

            animalList = new List<Animal>();
            animalList.Add(new Dog());
            animalList.Add(new Cat());
            return animalList;
        }
    }
}
