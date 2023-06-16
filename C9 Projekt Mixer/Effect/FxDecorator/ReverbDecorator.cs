using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class ReverbDecorator : FxDecorator
    {
        private double time;

        public ReverbDecorator(Effect _fx, int _mix, double _time) : base(_fx, _mix)
        {
            time = _time;
        }
        public override string Info()
        {
            return fx.Info() + $"\nReverb: \ntime {time}s, mix {mix}%";
        }
    }
}
