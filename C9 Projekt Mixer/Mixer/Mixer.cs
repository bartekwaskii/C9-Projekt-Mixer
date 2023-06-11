using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Mixer
    {
        private int channelsNumber;
        private List<Channel> channelsList = new List<Channel>();

        public Mixer(int _channelsNumber)
        {
            channelsNumber = _channelsNumber;
        }
        public Mixer(int _channesNumber, List<Channel> _chList)
        {
            channelsNumber = _channesNumber;
            if (_chList.Count <= _channesNumber)
                channelsList = _chList;
        }
        public void Initialize()
        {

        }
        public void AddChannel()
        {

        }
        public void AddFx(int _channel)
        {

        }
        public void RemoveFx(int _channel)
        {

        }
    }
}
