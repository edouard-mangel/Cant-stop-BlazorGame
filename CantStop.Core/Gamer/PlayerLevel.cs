using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Gamer
{
    public class CantStopPlayerLevel : IPlayerLevel
    {
        public CantStopPlayerLevel(string label, decimal timeMultiplier)
        {
            Label = label;
            TimeMultiplier = timeMultiplier;
        }

        public string Label { get; }
        public int TimePerTurn => (int)(DefaultTimePerTurnInMilliseconds * 60 * TimeMultiplier);
        private const int DefaultTimePerTurnInMilliseconds = 1000; // milliseconds
        private decimal TimeMultiplier { get; set; } = 1m;
        
        public static CantStopPlayerLevel Default => new CantStopPlayerLevel("Average", 1m);

    }
}
