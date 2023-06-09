using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class DeEsser : Fx
    {
        private double treshold;
        private int cutoffFreq;

        public DeEsser(int _mix, double _treshold, int _cutoffFrequency) : base(_mix)
        {
            treshold = _treshold;
            cutoffFreq = _cutoffFrequency;
        }

        public override string Info()
        {
            return $"\nDeEsser: \ntreshold {treshold}dB, cutoff frequency {cutoffFreq}Hz, mix {mix}%";
        }
    }
}
