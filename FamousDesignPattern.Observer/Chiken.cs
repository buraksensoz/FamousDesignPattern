using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Observer
{
    public class Chiken : IAnimal

    {
        public void ThankForFood()
        {
            Console.WriteLine("Chiken Says cluck cluck");
        }
    }
}
