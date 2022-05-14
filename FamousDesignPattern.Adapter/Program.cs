using System;

namespace FamousDesignPattern.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VGAPort _vgaPort = new VGAPort(); //VGAPort object is not IConnector
            IConnector connector = new VGAAdapter(_vgaPort); //We Convert it to IConnector with VGAAdapter Class
            DisplayManager playerDevice = new DisplayManager(connector); //playerDevice can use vga adapter
            playerDevice.PlayVideo();
        }
    }
}
