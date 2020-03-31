using CantStop.Core.Gamer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CantStop.Core.Board
{
    public class CantStopPlayerToken : IPlayableToken
    {
        private CantStopPlayer _owner {get; set;}
        public IPlayer Owner => _owner;
        public Color color { get; private set; }
        
        public CantStopPlayerToken(CantStopPlayer player)
        {
            _owner = player ;
        }
    }
}
