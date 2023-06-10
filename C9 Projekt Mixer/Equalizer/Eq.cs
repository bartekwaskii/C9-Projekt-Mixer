using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Eq : Equalizer
    {
        public Eq(double _f, double _lvl, double _q) : base(_f, _lvl, _q) { }
        public override string Info()
        {
            return $"\nEqualizer: \n{frequency}Hz, level {level}dB, Q {q}";
        }
    }
}