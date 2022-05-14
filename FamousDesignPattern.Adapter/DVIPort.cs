using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Adapter
{
    public class DVIPort : IConnector
    {
        public void Connect()
        {
            Console.WriteLine("Connected On Dvi Port");
        }
    }
}
