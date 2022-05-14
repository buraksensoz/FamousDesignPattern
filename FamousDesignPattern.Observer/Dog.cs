using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Observer
{
    public class Dog : IAnimal
    {
        public void ThankForFood()
        {
            Console.WriteLine("Dog Says Vuf Vuf");
        }
    }
}
