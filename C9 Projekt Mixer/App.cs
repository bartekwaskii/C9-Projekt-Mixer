using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class App
    {
        private App app;
        private Mixer mixer;
        private int channel;

        private MixerFactory mixerFactory = new MixerFactory();

        private App()
        {
            mixer = mixerFactory.CreateMixer();
        }
        public App GetApp()
        {
            if (app == null)
                app = new App();
            return app;
        }

    }
}
