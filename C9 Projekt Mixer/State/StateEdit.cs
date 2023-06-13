using C9_Projekt_Mixer.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class StateEdit : AppState
    {
        public StateEdit(App _context) : base(_context) { }
        public override void Btn1() // State: Input
        {
            context.ChangeState(new StateInput(context));
        }
        public override void Btn2() // State: Eq
        {
            context.ChangeState(new StateEq(context));
        }
        public override void Btn3() // State : Fx
        {
            context.ChangeState(new StateFx(context));
        }
        public override void Btn4() // Pan
        {
        }
        public override void Btn5() // Fader
        {
        }
        public override void Btn6() // Mute
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
    }
}
