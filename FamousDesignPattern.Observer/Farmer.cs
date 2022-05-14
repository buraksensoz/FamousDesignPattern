using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Observer
{
    public class Farmer
    {
        private readonly List<IAnimal> Animals;
        public Farmer()
        {
            Animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal) { 
            //Add Observer
            Animals.Add(animal);
        }

        public void FeedAnimals() {

            //Notify Observers
            Animals.ForEach(x => x.ThankForFood());
        
        }

    }
}
