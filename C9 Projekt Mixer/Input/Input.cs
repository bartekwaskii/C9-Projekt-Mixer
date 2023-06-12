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
            if(pad) { answ += ", pad is on"; }
            if (lowCut) { answ += ", low cut is on"; }
            if (highCut) { answ += ", high cut is on"; }
            return answ;
        }

        // Input control
        public void SwitchPad(bool _pad)
        {
            pad = _pad;
        }
        public void SetGain(double _gain)
        {
            inputGain = _gain;
        }


    }
}
