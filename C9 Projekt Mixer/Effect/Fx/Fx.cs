using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal abstract class Fx : Effect
    {
        public Fx(int _mix) : base(_mix) { }
    }
}
