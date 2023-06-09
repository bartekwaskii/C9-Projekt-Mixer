using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal abstract class Effect : IInfo
    {
        protected int mix;
        protected bool bypass;

        public Effect(int _mix)
        {
            mix = _mix;
            bypass = false;
        }

        public void Bypass()
        {
            if(bypass==true)
                bypass = false;
            else
                bypass = true;
        }
        public abstract string Info();

    }
}
