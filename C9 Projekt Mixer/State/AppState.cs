using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal abstract class AppState
    {
        protected App context;
        public AppState(App _context)
        {
            context = _context;
            StateInfo();
        }
        public abstract void Btn1();
        public abstract void Btn2();
        public abstract void Btn3();
        public abstract void Btn4();
        public abstract void Btn5();
        public abstract void Btn6();
        public abstract void Btn7();
        public abstract void Btn8();
        public abstract void Btn9();
        public abstract void StateInfo();
    }
}
