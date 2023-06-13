using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class StateStart : AppState
    {
        public StateStart(App _context) : base(_context) { }
        public override void Btn1() // Select channel
        {
        }
        public override void Btn2() // State: Edit
        {
            context.ChangeState(new StateEdit(context));
        }
        public override void Btn3() // Info/SignalChain
        {
        }
        public override void Btn4() // uinitialize
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
        public override void Btn9()
        {
        }
    }
}
