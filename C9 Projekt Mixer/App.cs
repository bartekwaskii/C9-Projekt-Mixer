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

        private App()
        {
            throw new NotImplementedException();
        }
        public App GetApp()
        {
            if (app == null)
                app= new App();
            return app;
        }

    }
}
