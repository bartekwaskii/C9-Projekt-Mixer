using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Mixer
    {
        private int channelsNumber;
        public List<Channel> channelsList { get; private set; }

        public Mixer(int _channelsNumber)
        {
            channelsList = new List<Channel>();
            channelsNumber = _channelsNumber;
        }
        public Mixer(int _channesNumber, List<Channel> _chList)
        {
            channelsList = new List<Channel>();
            channelsNumber = _channesNumber;
            if (_chList.Count <= _channesNumber)
                channelsList = _chList;
        }
        public string SignalChain(int _channel)
        {
            return channelsList[_channel - 1].SignalChain(_channel);
        }
        public Channel GetChannel(int _channel)
        {
            return channelsList[_channel - 1];
        }
        public void Initialize()
        {

        }

        // Fader + Mute
        public void SetVolume(int _channel, double _volume)
        {
            channelsList[_channel - 1].SetVolume(_volume);
        }
        public void SwitchMute(int _channel, bool _mute)
        {
            channelsList[_channel - 1].SwitchMute(_mute);
        }
        // Input
        public void SwitchPad(int _channel, bool _pad)
        {
            channelsList[_channel - 1].SwitchPad(_pad);
        }
        public void SetGain(int _channel, double _gain)
        {
            channelsList[_channel - 1].SetGain(_gain);
        }

        // Equalizer
        public void AddEq(int _channel, Equalizer _equalizer)
        {
            channelsList[_channel - 1].AddEq(_equalizer);
        }
        public void ClearEq(int _channel)
        {
            channelsList[_channel - 1].AddEq(null);
        }

        // Effect
        public void AddFx(int _channel, Effect _effect)
        {
            channelsList[_channel - 1].AddFx(_effect);
        }
        public void ClearFx(int _channel)
        {
            channelsList[_channel - 1].AddFx(null);
        }
    }
}
