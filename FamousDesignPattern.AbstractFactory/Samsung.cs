using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
    public class Samsung : Phone
    {
        public string Model { get; set; }
        public string Battery { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Samsung(string model, string battery, int width, int heigth)
        {
            Model = model;
            Battery = battery;
            Width = width;
            Heigth = heigth;
        }

        public string GetBattery() => Battery;
        public int GetHeigth() => Heigth;
        public int GetWidth() => Width;
        public string GetModel() => Model;

        public string ShowProperties()
        {
            return "Samsung " + Environment.NewLine
                + " Model:" + Model + Environment.NewLine
                + " Battery:" + Battery + Environment.NewLine
                + " HeigthxWidth:" + Heigth + "x" + Width;


        }

    }
}
