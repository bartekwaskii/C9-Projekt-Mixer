using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class EqDecorator : Equalizer
    {
        private Equalizer eq;
        public EqDecorator(Equalizer _eq, double _f, double _lvl, double _q) : base(_f, _lvl, _q)
        {
            eq = _eq;
        }
        public override string Info()
        {
            return eq.Info() + $"\n{frequency}Hz, level {level}dB, Q {q}";
        }
    }
}
