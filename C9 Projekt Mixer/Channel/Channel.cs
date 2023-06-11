using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Channel
    {
        private bool mute;
        private double fader;
        private Input input;
        private Equalizer equalizer;
        private Effect effect;
        private Panorama panorama;
        public Channel(bool _mute, double _fader, Input _input, Panorama _panorama)
        {
            mute = _mute;
            fader = _fader;
            input = _input;
            panorama = _panorama;
        }
        public void AddFx(Effect _effect)
        {
            effect = _effect;
        }
        public void AddEq(Equalizer _equalizer)
        {
            equalizer = _equalizer;
        }
        public void SwitchMute(bool _mute)
        {
            mute = _mute;
        }
        public string SignalChain(int _chNr)
        {
            string answ;
            answ = $"\nChannel {_chNr}\nSignal chain:\n";
            answ += input.Info();
            if (equalizer != null) { answ += System.Environment.NewLine + equalizer.Info(); }
            if (effect != null) { answ += System.Environment.NewLine + effect.Info(); }
            answ += $"\n\nOutput: \nfader {fader}dB";
            if (mute) { answ += ", Pad is on"; }
            return answ;
        }
        public void SetVolume(double _volume)
        {
            fader = _volume;
        }
    }
}
