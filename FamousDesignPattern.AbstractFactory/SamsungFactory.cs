using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
    public class SamsungFactory : IPhoneFactory
    {
        public Phone GetPhone(string model, string battery, int width, int heigth)
        {
            return new Samsung(model, battery, width, heigth);
        }
    }
}
