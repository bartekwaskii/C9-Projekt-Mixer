using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class TestClass
    {
        public static void Test()
        {
            /*// Input test
            var in1 = new Input(12, false, true, false);
            Console.WriteLine(in1.Info());

            // Equalizer test
            var eq1 = new Eq(440, -2, 3);
            var eqd1 = new EqDecorator(eq1, 300, -9, 6);
            Equalizer eqd2 = new EqDecorator(eqd1, 100, -3, 2);
            Console.WriteLine(eqd2.Info());

            // Effect test
            var fx1 = new Reverb(90, 1);
            var fxd1 = new ReverbDecorator(fx1, 40, 2);
            Console.WriteLine(fxd1.Info());

            // Panorama test
            var pan1 = new Panorama('L', 20);
            var pan2 = new Panorama('L', -2);
            Console.WriteLine(pan1.Info());
            Console.WriteLine(pan2.Info());*/

            // channel test
            var ch1 = new Channel(false, -10, new Input(25,false, true, false), new Panorama('R', 35));
            Console.WriteLine(ch1.SignalChain());
        }
    }
}
