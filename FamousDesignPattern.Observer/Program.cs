using System;

namespace FamousDesignPattern.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmer farmer = new Farmer();
            farmer.AddAnimal(new Dog());
            farmer.AddAnimal(new Cat());
            farmer.AddAnimal(new Chiken());
            farmer.AddAnimal(new Cow());

            farmer.FeedAnimals();
        }
    }
}
