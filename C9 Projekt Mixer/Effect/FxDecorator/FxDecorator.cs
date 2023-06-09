using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal abstract class FxDecorator : Effect
    {
        protected Effect fx;

        public FxDecorator(Effect _fx, int _mix): base(_mix)
        {
            fx = _fx;
        }
    }
}
