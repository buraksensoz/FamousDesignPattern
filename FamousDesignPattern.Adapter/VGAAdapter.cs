using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Adapter
{
    internal class VGAAdapter : IConnector
    {
        private readonly VGAPort _vgaPort;

        public VGAAdapter(VGAPort vgaPort)
        {
            _vgaPort = vgaPort;
        }
        public void Connect()
        {
            _vgaPort.Connect();
            Console.WriteLine("VGA Connected From Adapter");
        }
    }
}
