using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer.State
{
    internal class StateAddFx : AppState
    {
        public StateAddFx(App _context) : base(_context) { }
        public override void Btn1() // Compressor
        {
        }
        public override void Btn2() // DeEsser
        {
        }
        public override void Btn3() // Delay 
        {
        }
        public override void Btn4() // Limiter
        {
        }
        public override void Btn5() // Reverb
        {
        }
        public override void Btn6()
        {
        }
        public override void Btn7()
        {
        }
        public override void Btn8()
        {
        }
        public override void Btn9() // Exit
        {
            context.ChangeState(new StateStart(context));
        }
        public override void StateInfo()
        {
            
        }
    }
}
