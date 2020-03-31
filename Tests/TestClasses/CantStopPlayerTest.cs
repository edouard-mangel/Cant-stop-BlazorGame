using CantStop.Core.Game;
using CantStop.Core.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    internal class CantStopPlayerTest : CantStopPlayer
    {
        public CantStopPlayerTest() :base("test player")
        {
        }

        public CantStopPlayerTest(string name) : base(name)
        {
        }
    }
}
