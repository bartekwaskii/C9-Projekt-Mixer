using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class FxFactory
    {
        private Effect effect;
        public void GetFx(Mixer _mixer, int _channel)
        {
            effect = _mixer.channelsList[_channel - 1].effect;
        }
        public Effect CreateCompressor(int _channel, int _mix, double _treshold, double _makeup, double _ratio,
            int _attack, int _hold, int _release)
        {

            return null;
        }
        public Effect CrerateDeEsser()
        {
            return null;
        }
        public Effect CreateDelay()
        {
            return null;
        }
        public Effect CreateLimiter()
        {
            return null;
        }
        public Effect CreateReverb()
        {
            return null;
        }
    }
}
