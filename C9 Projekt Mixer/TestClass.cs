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
            // Input test
            var in1 = new Input(12, true, true, true);
            //Console.WriteLine(in1.Info());

            // Equalizer test
            var eq1 = new Eq(440, -2, 3);
            var eqd1 = new EqDecorator(eq1, 300, -9, 6);
            Equalizer eqd2 = new EqDecorator(eqd1, 100, -3, 2);
            /*Console.WriteLine(eq1.Info());
            Console.WriteLine(eqd2.Info());*/

            // Effect test
            var fx1 = new Compressor(100, -13, 2, 4, 10, 50, 100);
            var fx2 = new DeEsser(95, -10, 12000);
            var fx3 = new Delay(40, 400, 30);
            var fx4 = new Limiter(70, 3, 15, 0);
            var fx5 = new Reverb(90, 1);

            var fxd1 = new CompressorDecorator(fx1,55, -5, 0, 3, 10, 0, 10);
            var fxd2 = new DeEsserDecorator(fx2, 50, -12, 10000);
            var fxd3 = new DelayDecorator(fx3, 20, 250, 10);
            var fxd4 = new LimiterDecorator(fx4, 90, 6, 20, 0);
            var fxd5 = new ReverbDecorator(fx5, 40, 2);

            List<Effect> fxList = new List<Effect>
            {
                fx1, fx2, fx3, fx4, fx5,
                fxd1, fxd2, fxd3, fxd4, fxd5
            };
            /*foreach (Effect _f in fxList)
            {
                Console.WriteLine(_f.Info());
            }*/

            // Panorama test
            var pan1 = new Panorama('L', 20);
            var pan2 = new Panorama('L', -2);
            //Console.WriteLine(pan1.Info());
            //Console.WriteLine(pan2.Info());

            // channel test
            var ch1 = new Channel(false, -10, new Input(25, false, true, false), new Panorama('R', 35));
            ch1.AddEq(eqd1);
            ch1.AddFx(fx1);
            //Console.WriteLine(ch1.SignalChain(1));

            var app = App.GetApp();
            app.InitializeMixer(16);
            app.SelectChannel(1);
            app.SetVolume(-0.75);
            app.SwitchMute(true);
            app.SwitchPad(true);
            app.SetGain(25);
            app.AddEq(400, -5, 8);
            app.AddEq(100, -3, 2);
            app.SignalChain();
            app.ClearEq();
            app.SwitchMute(false);
            app.SignalChain();

            app.InitializeMixer(16);
            app.Btn1();

        }
    }
}
