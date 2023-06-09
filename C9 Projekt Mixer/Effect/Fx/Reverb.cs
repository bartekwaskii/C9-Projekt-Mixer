using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Reverb : Fx
    {
        private double time;

        public Reverb(int _mix, double _time) : base(_mix)
        {
            time = _time;
        }
        public override string Info()
        {
            return $"Reverb: time {time}s, mix {mix}%";
        }
    }
}
