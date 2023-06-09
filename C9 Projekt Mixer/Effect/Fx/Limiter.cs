using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Limiter : Fx
    {
        private double input, output;
        private int release;

        public Limiter(int _mix, double _input,  int _release, double _output) : base(_mix)
        {
            input = _input; 
            output = _output; 
            release = _release;
        }

        public override string Info()
        {
            return $"\nLimiter: \ninput {input}dB, release {release}ms, output {output}dB";
        }
    }
}
