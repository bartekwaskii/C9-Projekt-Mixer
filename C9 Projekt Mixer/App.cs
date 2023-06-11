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
        private static Mixer mixer;
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
        public void SetVolume(double _volume)
        {
            mixer.SetVolume(channel, _volume);
        }
        public void SignalChain()
        {
            Console.WriteLine(mixer.SignalChain(channel));
        }

    }
}
