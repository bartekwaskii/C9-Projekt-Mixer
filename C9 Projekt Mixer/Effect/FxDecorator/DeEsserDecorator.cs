using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class DeEsserDecorator : FxDecorator
    {
        private double treshold;
        private int cutoffFreq;

        public DeEsserDecorator(Effect _fx, int _mix, double _treshold, int _cutoffFrequency) : base(_fx, _mix)
        {
            treshold = _treshold;
            cutoffFreq = _cutoffFrequency;
        }

        public override string Info()
        {
            return fx.Info() + $"\nEsser: \ntreshold {treshold}dB, cutoff frequency {cutoffFreq}Hz, mix {mix}%";
        }
    }
}
