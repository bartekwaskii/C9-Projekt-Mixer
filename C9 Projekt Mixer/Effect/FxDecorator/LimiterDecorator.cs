using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class LimiterDecorator : FxDecorator
    {
        private double input, output;
        private int release;

        public LimiterDecorator(Effect _fx, int _mix, double _input, int _release, double _output) : base(_fx, _mix)
        {
            input = _input;
            output = _output;
            release = _release;
        }

        public override string Info()
        {
            return fx.Info() + $"\nLimiter: \ninput {input}dB, release {release}ms, output {output}dB";
        }
    }
}
