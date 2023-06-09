using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class CompressorDecorator : FxDecorator
    {
        private double treshold, ratio, makeup;
        private int attack, hold, release;

        public CompressorDecorator(Effect _fx, int _mix, double _treshold, double _makeup, double _ratio,
            int _attack, int _hold, int _release) : base(_fx, _mix)
        {
            treshold = _treshold;
            ratio = _ratio;
            makeup = _makeup;
            attack = _attack;
            hold = _hold;
            release = _release;
        }

        public override string Info()
        {
            return fx.Info() + $"Compressor: treshold {treshold}dB, ratio 1:{ratio}, makup {makeup}dB," +
                $" atack {attack}ms, hold {hold}ms, release {release}ms, mix {mix}%";
        }
    }
}
