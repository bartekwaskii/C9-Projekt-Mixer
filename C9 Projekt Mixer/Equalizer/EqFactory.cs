using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class EqFactory
    {
        public Equalizer CreateEq(Mixer _mixer, int _channel, double _f, double _lvl, double _q)
        {
            if (_mixer.channelsList[_channel-1].equalizer != null)
            {
                return new EqDecorator(_mixer.channelsList[_channel - 1].equalizer, _f, _lvl, _q);
            }
            else
            {
                return new Eq(_f, _lvl, _q);
            }
        }
    }
}
