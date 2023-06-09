using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal abstract class Equalizer : IInfo
    {
        protected double frequency, level, q;

        public Equalizer(double _frequency, double _level, double _q)
        {
            frequency = _frequency;
            level = _level;
            q = _q;
        }
        public abstract string Info();
    }
}
