using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
   public interface IPhoneFactory
    {
        Phone GetPhone(string model, string battery, int width, int heigth);
    }
}
