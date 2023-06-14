using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class StateEq : AppState
    {
        public StateEq(App _context) : base(_context) { }
        public override void Btn1() // AddEq
        {
        }
        public override void Btn2() // ClearEq
        {
        }
        public override void Btn3()
        {
        }
        public override void Btn4()
        {
        }
        public override void Btn5()
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
