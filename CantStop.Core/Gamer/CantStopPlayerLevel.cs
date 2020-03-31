using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantStop.Core.Gamer
{
    public class CantStopPlayerLevelLookup
    {
        public static readonly IEnumerable<CantStopPlayerLevel> _playerLevels =
            new[] {
                new CantStopPlayerLevel("Noob", 2m ), 
                new CantStopPlayerLevel("Beginner", 1.5m), 
                new CantStopPlayerLevel("Average", 1),  
                new CantStopPlayerLevel("Advanced" , 0.75m), 
                new CantStopPlayerLevel("Expert" , 0.5m)
            };
        
        public CantStopPlayerLevel GetPlayerLevel(string label)
        {
            var playerLevel = _playerLevels.FirstOrDefault(x => x.Label.Trim().ToUpperInvariant().Equals(label.ToUpperInvariant()));
            return playerLevel ?? CantStopPlayerLevel.Default;
        }

    }
}
