using System;
using System.Collections.Generic;
using System.Text;

namespace FamousDesignPattern.AbstractFactory
{
    public class Lg : Phone
    {
        public string Model { get; set; }
        public string Battery { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Lg(string model, string battery, int width, int heigth)
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
            return "Lg " + Environment.NewLine
                + " Model:" + Model + Environment.NewLine
                + " Batarya:" + Battery + Environment.NewLine
                + " HeigthxWidth:" + Heigth + "x" + Width;


        }

    }
}
