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
        private Mixer mixer;
        private static int channel;

        private MixerFactory mixerFactory = new MixerFactory();

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
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mixer.SignalChain(channel));
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
        

    }
}
