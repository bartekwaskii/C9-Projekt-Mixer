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
            if (_side == 'L' || _side == 'R')
                side = _side;
            else side = 'C';
            if (_volume >= 0)
                if (_volume <= 100)
                    volume = _volume;
                else volume = 100;
            else volume = 0;
        }
        public void SetPan(char _side, int _volume)
        {
            side = _side;
            volume = _volume;
        }
        public string Info()
        {   if (side == 'C' || volume == 0)
                return "Panorama:  C";
            return $"\nPanorama:  {side}{volume}";
        }
    }
}
