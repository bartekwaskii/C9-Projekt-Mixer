using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class FxFactory
    {
        //private Effect effect;
        /*public void GetFx(Mixer _mixer, int _channel)
        {
            effect = _mixer.channelsList[_channel - 1].effect;
        }*/
        public Effect CreateCompressor(App _context, int _mix, double _treshold,
            double _makeup, double _ratio, int _attack, int _hold, int _release)
        {
            if (_context.mixer.channelsList[_context.channel].effect == null)
            {
                return new Compressor(_mix, _treshold, _makeup, _ratio, _attack, _hold, _release);
            }
            else
            {
                return new CompressorDecorator(_context.mixer.channelsList[_context.channel].effect, 
                    _mix, _treshold, _makeup, _ratio, _attack, _hold, _release);
            }
        }
        public Effect CreateDeEsser(App _context, int _mix, double _treshold, int _cutoffFrequency)
        {
            if (_context.mixer.channelsList[_context.channel].effect == null)
            {
                return new DeEsser(_mix, _treshold, _cutoffFrequency);
            }
            else
            {
                return new DeEsserDecorator(_context.mixer.channelsList[_context.channel].effect,
                    _mix, _treshold, _cutoffFrequency);
            }
        }
        public Effect CreateDelay(App _context, int _mix, double _delay, int _feedback)
        {
            if (_context.mixer.channelsList[_context.channel].effect == null)
            {
                return new Delay(_mix, _delay, _feedback);
            }
            else
            {
                return new DelayDecorator(_context.mixer.channelsList[_context.channel].effect,
                    _mix, _delay, _feedback);
            }
        }
        public Effect CreateLimiter(App _context, int _mix, double _input, int _release, double _output)
        {
            if (_context.mixer.channelsList[_context.channel].effect == null)
            {
                return new Limiter(_mix, _input, _release, _output);
            }
            else
            {
                return new LimiterDecorator(_context.mixer.channelsList[_context.channel].effect,
                    _mix, _input, _release, _output);
            }
        }
        public Effect CreateReverb(App _context, int _mix, double _time)
        {
            if (_context.mixer.channelsList[_context.channel].effect == null)
            {
                return new Reverb(_mix, _time);
            }
            else
            {
                return new ReverbDecorator(_context.mixer.channelsList[_context.channel].effect,
                    _mix, _time);
            }
        }
    }
}
