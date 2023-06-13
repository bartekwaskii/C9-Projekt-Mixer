using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer.State
{
    internal class StateInput : AppState
    {
        public StateInput(App _context) : base(_context) { }
        public override void Btn1() // Gain
        {
        }
        public override void Btn2() // Pad
        {
        }
        public override void Btn3() // Low cut
        {
        }
        public override void Btn4() // High cut
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
    }
}
