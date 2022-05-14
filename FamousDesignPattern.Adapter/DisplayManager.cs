using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousDesignPattern.Adapter
{
    
    public class DisplayManager
    {
        private readonly IConnector _connector;
        public DisplayManager(IConnector connector)
        {
            _connector = connector;
        }

        public void PlayVideo() {
            _connector.Connect();
            
        }

    }
}
