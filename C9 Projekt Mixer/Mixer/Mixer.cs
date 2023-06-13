using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Mixer
    {
        public int channelsNumber { get; private set; }
        public List<Channel> channelsList { get; private set; }

        public Mixer(int _channesNumber, List<Channel> _chList)
        {
            channelsList = new List<Channel>();
            channelsNumber = _channesNumber;
            if (_chList.Count <= _channesNumber)
                channelsList = _chList;
        }















        // ŚMIETNIK ---------------------------------
        public string SignalChain(int _channel)
        {
            return channelsList[_channel].SignalChain(_channel);
        }
        public Channel GetChannel(int _channel)
        {
            return channelsList[_channel];
        }
        public void Initialize()
        {

        }

        // Fader + Mute
        public void SetVolume(int _channel, double _volume)
        {
            channelsList[_channel].SetVolume(_volume);
        }
        public void SwitchMute(int _channel, bool _mute)
        {
            channelsList[_channel].SwitchMute(_mute);
        }
        // Input
        public void SwitchPad(int _channel, bool _pad)
        {
            channelsList[_channel].SwitchPad(_pad);
        }
        public void SetGain(int _channel, double _gain)
        {
            channelsList[_channel].SetGain(_gain);
        }

        // Equalizer
        public void AddEq(int _channel, Equalizer _equalizer)
        {
            channelsList[_channel].AddEq(_equalizer);
        }
        public void ClearEq(int _channel)
        {
            channelsList[_channel].AddEq(null);
        }

        // Effect
        public void AddFx(int _channel, Effect _effect)
        {
            channelsList[_channel].AddFx(_effect);
        }
        public void ClearFx(int _channel)
        {
            channelsList[_channel].AddFx(null);
        }
    }
}
