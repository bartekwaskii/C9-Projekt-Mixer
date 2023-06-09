using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class DelayDecorator : FxDecorator
    {
        private double delay;
        private int feedback;

        public DelayDecorator(Effect _fx, int _mix, double _delay, int _feedback) : base(_fx, _mix)
        {
            delay = _delay;
            feedback = _feedback;
        }

        public override string Info()
        {
            return fx.Info() + $"\nDelay: delay {delay}s, feedback {feedback}, mix {mix}%";
        }
    }
}
