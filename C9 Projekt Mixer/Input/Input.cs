using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Input : IInfo
    {
        private double inputGain;
        private bool pad, lowCut, highCut;
        public Input(double _gain, bool _pad, bool _lowCut, bool _highCut)
        {
            inputGain = _gain;
            pad = _pad;
            lowCut = _lowCut;
            highCut = _highCut;
        }
        public string Info()
        {
            string answ;
            answ = $"\nInput: \ngain {inputGain}dB";
            if(pad) { answ += ", PAD"; }
            if (lowCut) { answ += ", Low cut"; }
            if (highCut) { answ += ", High cut"; }
            return answ;
        }

        // Input control
        public void SetGain(double _gain)
        {
            inputGain = _gain;
        }
        public void SwitchPad(bool _pad)
        {
            pad = _pad;
        }
        public void SwitchLowCut(bool _lowCut)
        {
            lowCut = _lowCut;
        }
        public void SwitchHighCut(bool _highCut)
        {
            highCut = _highCut;
        }


    }
}
