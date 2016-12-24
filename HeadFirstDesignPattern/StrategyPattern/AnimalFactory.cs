using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattrn
{
    class AnimalFactory
    {
        private static AnimalFactory instance;

        public static AnimalFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimalFactory();
                }
                return instance;
            }
        }

        List<Animal> animalList;

        public List<Animal> getAnimals()
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
