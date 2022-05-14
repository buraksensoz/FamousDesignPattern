using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
    public class LgFactory : IPhoneFactory
    {
        public Phone GetPhone(string model, string battery, int width, int heigth)
        {
            return new Lg(model, battery, width, heigth);
        }
    }
}
