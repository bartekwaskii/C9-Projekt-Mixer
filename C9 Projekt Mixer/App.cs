using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class App
    {
        private static App app;
        public AppState state { get; private set; }
        public int channel { get; private set; }
        public  Mixer mixer { get; private set; }

        private MixerFactory mixerFactory = new MixerFactory();
        private EqFactory eqFactory = new EqFactory();
        private FxFactory fxFactory = new FxFactory();

        private App()
        {
            channel = 0;
            state = new StateStart(this);
            mixer = mixerFactory.InitializeMixer(8);
        }
        public static App GetApp()
        {
            if (app == null)
            {
                app = new App(); 
            }
            return app;
        }

        public void ChangeState(AppState _state)
        {
            state = _state;
        }

        public void SelectChannel(int _channelNumber)
        {
            channel = _channelNumber - 1; // !!! WAŻNE !!!
        }
        public void Initialize(int _channelsNumber)
        {
            mixer = mixerFactory.InitializeMixer(_channelsNumber);
        }

        public void Btn1() => state.Btn1();
        public void Btn2() => state.Btn2();
        public void Btn3() => state.Btn3();
        public void Btn4() => state.Btn4();
        public void Btn5() => state.Btn5();
        public void Btn6() => state.Btn6();
        public void Btn7() => state.Btn7();
        public void Btn8() => state.Btn8();
        public void Btn9() => state.Btn9();












        // ŚMIETNIK ----------------------------------------
        public void SignalChain()
        {
            mixer.SignalChain(channel);
        }

        // Channel control
        public void SetVolume(double _volume)
        {
            mixer.SetVolume(channel, _volume);
        }
        public void SwitchMute(bool _mute)
        {
            mixer.SwitchMute(channel, _mute);
        }

        // Input
        public void SwitchPad(bool _pad)
        {
            mixer.SwitchPad(channel, _pad);
        }
        public void SetGain(double _gain)
        {
            mixer.SetGain(channel, _gain);
        }

        // Equalizer
        public void AddEq(double _f, double _lvl, double _q)
        {
            mixer.AddEq(channel, eqFactory.CreateEq(mixer, channel, _f, _lvl, _q));
        }
        public void ClearEq()
        {
            mixer.ClearEq(channel);
        }

        // Effect
        public void AddCompressor(int _channel, int _mix, double _treshold,
            double _makeup, double _ratio, int _attack, int _hold, int _release)
        {

            //return mixer.AddFx(fxFactory.CreateCompressor());
        }
    }
}
