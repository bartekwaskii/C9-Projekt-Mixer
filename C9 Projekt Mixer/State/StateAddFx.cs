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
            Console.Clear();
            Console.Write("New compressor:\nmix: ");
            int _mix = Convert.ToInt16(Console.ReadLine());
            Console.Write("treshold: ");
            double _treshold = Convert.ToDouble (Console.ReadLine());
            Console.Write("makeup: ");
            double _makeup = Convert.ToDouble(Console.ReadLine());
            Console.Write("ratio: ");
            double _ratio = Convert.ToDouble(Console.ReadLine());
            Console.Write("attack: ");
            int _attack = Convert.ToInt16(Console.ReadLine());
            Console.Write("hold: ");
            int _hold = Convert.ToInt16(Console.ReadLine());
            Console.Write("release: ");
            int _release = Convert.ToInt16(Console.ReadLine());
            if (_mix > 0 && _mix <= 100)
                if (_ratio >= 1) 
                    if (_attack > 0 && _hold > 0 && _release > 0)
                    {
                        context.mixer.channelsList[context.channel].
                            AddFx(context.fxFactory.CreateCompressor(context, 
                            _mix, _treshold, _makeup, _ratio, _attack, _hold, _release));
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Added successfully");
                        Console.ForegroundColor= ConsoleColor.Gray;
                        Thread.Sleep(1000);
                    }
            StateInfo();

        }
        public override void Btn2() // DeEsser
        {
            Console.Clear();
            Console.Write("New compressor:\nmix: ");
            int _mix = Convert.ToInt16(Console.ReadLine());
            Console.Write("treshold: ");
            double _treshold = Convert.ToDouble(Console.ReadLine());
            Console.Write("cut off frequency: ");
            int _cutoffFrequency = Convert.ToInt32(Console.ReadLine());
            if (_mix > 0 && _mix <= 100)
                if (_cutoffFrequency >= 20)
                {
                    context.mixer.channelsList[context.channel].
                            AddFx(context.fxFactory.CreateDeEsser(context,
                            _mix, _treshold, _cutoffFrequency));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Added successfully");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                }
            StateInfo();
        }

        public override void Btn3() // Delay 
        {
            Console.Clear();
            Console.Write("New delay:\nmix: ");
            int _mix = Convert.ToInt16(Console.ReadLine());
            Console.Write("delay: ");
            double _delay = Convert.ToDouble(Console.ReadLine());
            Console.Write("feedback: ");
            int _feedback= Convert.ToInt32(Console.ReadLine());
            if (_mix > 0 && _mix <= 100)
                if (_delay > 0)
                    if (_feedback > 0)
                    {
                        context.mixer.channelsList[context.channel].
                                AddFx(context.fxFactory.CreateDelay(context,
                                _mix, _delay, _feedback));
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Added successfully");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1000);
                    }
            StateInfo();
        }
    
        public override void Btn4() // Limiter
        {
            Console.Clear();
            Console.Write("New limiter:\nmix: ");
            int _mix = Convert.ToInt16(Console.ReadLine());
            Console.Write("input: ");
            double _input = Convert.ToDouble(Console.ReadLine());
            Console.Write("release: ");
            int _release = Convert.ToInt16(Console.ReadLine());
            Console.Write("output: ");
            double _output = Convert.ToDouble(Console.ReadLine());
            if (_mix > 0 && _mix <= 100)
                if (_release > 0)
                {
                    context.mixer.channelsList[context.channel].
                            AddFx(context.fxFactory.CreateLimiter(context,
                            _mix,_input, _release, _output));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Added successfully");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                }
            StateInfo();
        }
        public override void Btn5() // Reverb
        {
            Console.Clear();
            Console.Write("New limiter:\nmix: ");
            int _mix = Convert.ToInt16(Console.ReadLine());
            Console.Write("time: ");
            double _time = Convert.ToDouble(Console.ReadLine());
            if (_mix > 0 && _mix <= 100)
                if (_time > 0)
                {
                    context.mixer.channelsList[context.channel].
                            AddFx(context.fxFactory.CreateReverb(context,
                            _mix, _time));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Added successfully");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                }
            StateInfo();
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
            Console.WriteLine("Add effect tab:\n1) Compressor\n2) DeEsser\n3) Delay\n4) Limiter\n5) Reverb\n9) Exit");
            
        }
    }
}
