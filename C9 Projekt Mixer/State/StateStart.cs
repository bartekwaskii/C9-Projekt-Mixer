using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class StateStart : AppState
    {
        public StateStart(App _context) : base(_context) { StateInfo(); }
        public override void Btn1() // Select channel
        {
            Console.Clear();
            int num = context.mixer.channelsNumber;
            Console.WriteLine($"Select channel (1-{num})");
            int channel = Convert.ToInt16(Console.ReadLine());
            if (channel >= 1 && channel <= num)
            {
                context.SelectChannel(channel);
                Console.WriteLine($"Channel {channel} selected");
                Thread.Sleep(1000);
            }
            StateInfo();
        }
        public override void Btn2() // State: Edit
        {
            context.ChangeState(new StateEdit(context));
        }
        public override void Btn3() // Info/SignalChain
        {
            context.mixer.channelsList[context.channel].SignalChain(context.channel);
        }
        public override void Btn4() // Initialize
        {
            Console.Clear();
            Console.WriteLine("Initializing mixer\nEnter nuber of channels: ");
            int num = Convert.ToInt16(Console.ReadLine());
            if(num > 0)
            {
                context.Initialize(num);
            }
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
        public override void Btn9()
        {
        }
        public void StateInfo()
        {
            Console.Clear();
            Console.WriteLine("1) Select channel\n2) Edit channel\n3) Signal chain\n4) Initialize mixer");
        }
    }
}
