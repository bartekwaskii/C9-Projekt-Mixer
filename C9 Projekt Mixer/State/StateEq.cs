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
            Console.Clear();
            Console.Write("New equalizer band:\nfrequency: ");
            double _freq = Convert.ToDouble(Console.ReadLine());
            Console.Write("level: ");
            double _lvl = Convert.ToDouble(Console.ReadLine());
            Console.Write("Q: ");
            double _q = Convert.ToDouble(Console.ReadLine());
            if( _freq > 0 && _q > 0 && _q <= 10 ) 
            {
                context.mixer.channelsList[context.channel].AddEq(context.eqFactory.
                    CreateEq(context.mixer, context.channel, _freq, _lvl, _q));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Added successfully");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1000);
            }
            StateInfo();
        }
        public override void Btn2() // ClearEq
        {
            context.mixer.channelsList[context.channel].AddEq(null);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Equalizer is cleared");
            Console.ForegroundColor= ConsoleColor.Gray;
            Thread.Sleep(1000);
            StateInfo();
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
            Console.Clear();
            Console.WriteLine("Equalizer tab:\n1) Add band\n2) Clear equalizer\n9) Exit");
        }
    }


}
