using System;

namespace FamousDesignPattern.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SamsungFactory factroy = new SamsungFactory();
            var phoneX = factroy.GetPhone("S8", "Panasonic", 4, 6);
            Console.WriteLine(phoneX.ShowProperties());

            LgFactory factroy2 = new LgFactory();
            var phoneY = factroy2.GetPhone("V10", "Duracell", 3, 6);
            Console.WriteLine(phoneY.ShowProperties());
        }
    }
}
