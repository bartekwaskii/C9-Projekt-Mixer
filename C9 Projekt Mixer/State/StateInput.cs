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
            Console.Clear();
            Console.WriteLine("Gain:\nEnter level");
            double _gain = Convert.ToDouble(Console.ReadLine());
            if(_gain >= 0 )
            {
                context.mixer.channelsList[context.channel].input.SetGain(_gain);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Gain set to {_gain}dB");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1000);
            }
            StateInfo();
        }
        public override void Btn2() // PAD
        {
            Console.Clear();
            Console.WriteLine("PAD:\n1) Turn on\n2) Turn off");
            int _mute = Convert.ToInt16(Console.ReadLine());
            if (_mute == 1)
            {
                context.mixer.channelsList[context.channel].input.SwitchPad(true);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("PAD turned on");
                Thread.Sleep(1000);
            }
            else if (_mute == 2)
            {
                context.mixer.channelsList[context.channel].input.SwitchPad(false);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("PAD turned off");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            StateInfo();
        }
        public override void Btn3() // Low cut
        {
            Console.Clear();
            Console.WriteLine("Low cut:\n1) Turn on\n2) Turn off");
            int _mute = Convert.ToInt16(Console.ReadLine());
            if (_mute == 1)
            {
                context.mixer.channelsList[context.channel].input.SwitchLowCut(true);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Low cut turned on");
                Thread.Sleep(1000);
            }
            else if (_mute == 2)
            {
                context.mixer.channelsList[context.channel].input.SwitchLowCut(false);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Low cut turned off");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            StateInfo();
        }
        public override void Btn4() // High cut
        {
            Console.Clear();
            Console.WriteLine("High cut:\n1) Turn on\n2) Turn off");
            int _mute = Convert.ToInt16(Console.ReadLine());
            if (_mute == 1)
            {
                context.mixer.channelsList[context.channel].input.SwitchHighCut(true);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("High cut turned on");
                Thread.Sleep(1000);
            }
            else if (_mute == 2)
            {
                context.mixer.channelsList[context.channel].input.SwitchHighCut(false);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("High cut turned off");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            StateInfo();
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
            Console.Clear ();
            Console.WriteLine("Input tab:\n1) Gain\n2) Pad\n3) Low cut\n4) High cut\n9) Exit");

        }
    }
}
