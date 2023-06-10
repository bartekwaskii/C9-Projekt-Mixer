using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class ChannelFactory
    {
        private InputFactory _inputFactory = new InputFactory();
        private PanoramaFactory _panoramaFactory = new PanoramaFactory();

        public Channel CreateChannel1()
        {
            return new Channel(false,0,_inputFactory.CreateInput(), _panoramaFactory.CreatePanorama());
        }
    }
}
