using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Channel
    {
        private bool mute;
        private double fader;
        private Input input;
        private Panorama panorama;

        public Equalizer equalizer { get; private set; }
        public Effect effect { get; private set; }

        public Channel(bool _mute, double _fader, Input _input, Panorama _panorama)
        {
            mute = _mute;
            fader = _fader;
            input = _input;
            panorama = _panorama;
        }
        public string SignalChain(int _chNr)
        {
            // cw
            Console.Clear();
            if (mute)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write($"Channel {_chNr + 1}");
            if (mute)
            {
                Console.Write(" MUTED");
            }
            Console.WriteLine("\nSignal chain:");
            Console.WriteLine(input.Info());
            if (equalizer != null)
            {
                Console.WriteLine(equalizer.Info());
            }
            if (effect != null)
            {
                Console.WriteLine(effect.Info());
            }
            Console.WriteLine($"\nOutput: \nfader {fader}dB");
            Console.ForegroundColor = ConsoleColor.Gray;

            // return
            string answ;
            answ = $"\nChannel {_chNr + 1}";
            if (mute)
            {
                answ += " MUTED";
            }
            answ += "\nSignal chain:\n";
            answ += input.Info();
            if (equalizer != null) { answ += System.Environment.NewLine + equalizer.Info(); }
            if (effect != null) { answ += System.Environment.NewLine + effect.Info(); }
            answ += $"\n\nOutput: \nfader {fader}dB";
            
            return answ;

        }
        // Fader + Mute
        public void SetVolume(double _volume)
        {
            fader = _volume;
        }
        public void SwitchMute(bool _mute)
        {
            mute = _mute;
        }

        // Input
        public void SwitchPad(bool _pad)
        {
            input.SwitchPad(_pad);
        }
        public void SetGain(double _gain)
        {
            input.SetGain(_gain);
        }

        // Equalizer
        public void AddEq(Equalizer _equalizer)
        {
            equalizer = _equalizer;
        }

        // Effect
        public void AddFx(Effect _effect)
        {
            effect = _effect;
        }
    }
}
