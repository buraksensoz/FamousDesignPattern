using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
   public interface Phone
    {
        public string GetModel();
        public string GetBattery();
        public int GetWidth();
        public int GetHeigth();

        public string ShowProperties();
    }
}
