﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class PanoramaFactory
    {
        public Panorama CreatePanorama()
        {
            return new Panorama('C', 0);
        }
    }
}
