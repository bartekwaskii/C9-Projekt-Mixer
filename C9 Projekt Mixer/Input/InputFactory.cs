using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer.Panorama
{
    internal class InputFactory
    {
        public Input CreateInput()
        {
            return new Input(0, false, false, false);
        }
    }
}
