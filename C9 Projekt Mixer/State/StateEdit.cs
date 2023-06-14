using C9_Projekt_Mixer.State;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            char s;
            int l;
            Console.Clear();
            Console.WriteLine("Panorama\nSelect side (L/R/C)");
            char _side = Convert.ToChar(Console.ReadLine());
            if (_side == 'C')
            {
                s = _side;
                l = 0;
                context.mixer.channelsList[context.channel].panorama.SetPan(s, l);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Panorma set to Center");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1000);
            }
            else if(_side == 'L' || _side == 'R')
            {
                s = _side;
                Console.WriteLine("Enter volume (0-100)");
                int _level = Convert.ToInt32(Console.ReadLine());
                if (_level >0 && _level <= 100)
                {
                    l = _level;
                    context.mixer.channelsList[context.channel].panorama.SetPan(s, l);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Panorama set to {s}{l}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                }
            }
            StateInfo();
        }
        public override void Btn5() // Fader
        {
            Console.Clear();
            Console.WriteLine("Fader:\nEnter volume");
            double _vol = Convert.ToDouble(Console.ReadLine());
            context.mixer.channelsList[context.channel].SetVolume(_vol);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Fader set to {_vol}dB");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1000);
            StateInfo();

        }
        public override void Btn6() // Mute
        {
            Console.Clear();
            Console.WriteLine("Mute:\n1) Mute channel\n2) Unmute channel");
            int _mute = Convert.ToInt16(Console.ReadLine());
            if(_mute == 1)
            {
                context.mixer.channelsList[context.channel].SwitchMute(true);
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"channel {context.channel + 1} muted");
                Thread.Sleep(1000);
            }
            else if(_mute == 2)
            {
                context.mixer.channelsList[context.channel].SwitchMute(false);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"channel {context.channel + 1} unmuted");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            StateInfo();
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
            Console.WriteLine("Edit tab:");
            Console.WriteLine("1) Input\n2) Equalizer\n3) Effects\n4) Panorama\n5) Fader\n6) Mute\n9) Exit");
        }
    }
}
