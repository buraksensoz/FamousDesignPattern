using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Observer
{
    public class Cow : IAnimal
    {
        public void ThankForFood()
        {
            Console.WriteLine("Cow Says Mooo");
        }
    }
}
