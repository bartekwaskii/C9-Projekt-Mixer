using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Projekt_Mixer
{
    internal class Mixer
    {
        private int id, channelsNumber;
        private List<Channel> channelsList = new List<Channel>();

        public Mixer(int _id, int _channelsNumber)
        {
            id = _id;
            channelsNumber = _channelsNumber;
        }
        public Mixer(int _id, int _channesNumber, List<Channel> _chList)
        {
            id = _id;
            channelsNumber = _channesNumber;
            if (_chList.Count <= _channesNumber)
                channelsList = _chList;
        }
    }
}
