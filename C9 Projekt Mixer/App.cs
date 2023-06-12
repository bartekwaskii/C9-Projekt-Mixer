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
        private static int channel;
        public Mixer mixer { get; private set; }

        private MixerFactory mixerFactory = new MixerFactory();
        private EqFactory eqFactory = new EqFactory();
        private FxFactory fxFactory = new FxFactory();

        private App() { }
        public static App GetApp()
        {
            if (app == null)
            {
                app = new App();
                channel = 1;
            }
            return app;
        }
        public void InitializeMixer(int _channels)
        {
            mixer = mixerFactory.InitializeMixer(_channels);
        }
        public void SelectChannel(int _channelNumber)
        {
            channel = _channelNumber;
        }
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
        public void AddDeEsser()
        {

        }
        public void AddDelay()
        {

        }
        public void AddLimiter()
        {

        }
        public void AddReverb()
        {

        }
        public void RemoveFx()
        {

        }
    }
}
