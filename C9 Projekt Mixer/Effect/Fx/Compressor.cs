using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Compressor : Fx
    {
        private double treshold, ratio, makeup;
        private int attack, hold, release;

        public Compressor(int _mix, double _treshold, double _makeup, double _ratio,
            int _attack, int _hold, int _release) : base(_mix)
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
            return $"\nCompressor: \ntreshold {treshold}dB, ratio 1:{ratio}, makup {makeup}dB," +
                $" atack {attack}ms, hold {hold}ms, release {release}ms, mix {mix}%";
        }
    }
}
