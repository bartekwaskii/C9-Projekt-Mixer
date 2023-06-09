using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Delay : Fx
    {
        private double delay;
        private int feedback;

        public Delay(int _mix, double _delay, int _feedback) : base(_mix)
        {
            delay = _delay;
            feedback = _feedback;
        }

        public override string Info()
        {
            return $"\nDelay: \ndelay {delay}s, feedback {feedback}%, mix {mix}%";
        }

    }
}
