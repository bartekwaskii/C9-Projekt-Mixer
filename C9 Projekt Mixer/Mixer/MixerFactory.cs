using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class MixerFactory
    {
        public Mixer InitializeMixer(int _channels)
        {
            ChannelFactory chFactory = new ChannelFactory();
            List<Channel> chList = new List<Channel>();

            for(int i = 0; i < _channels; i++)
            {
                chList.Add(chFactory.CreateChannel1());
            }
            return new Mixer(_channels, chList);
        }

    }
}
