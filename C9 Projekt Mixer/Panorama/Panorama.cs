using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Panorama : IInfo
    {
        private char side;
        private int volume;
        public Panorama(char _side, int _volume)
        {
            side = _side;
            volume = _volume;
        }
        public void SetPan(char _side, int _volume)
        {
            side = _side;
            volume = _volume;
        }
        public string Info()
        {   if (side == 'C' || volume == 0)
                return "\nPanorama:\nCentral";
            return $"\nPanorama:\n{side}{volume}";
        }
    }
}
