using CantStop.Core.Gamer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CantStop.Core.Board
{
    public class CantStopNeutralToken : IToken
    {
        public Color color { get; private set; }
        public bool IsPlayed { get; set; }
        public CantStopNeutralToken()
        {
            color = Color.Black;
        }
    }
}
