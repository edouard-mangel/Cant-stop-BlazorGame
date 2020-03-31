using CantStop.Core.Exceptions;
using CantStop.Core.Plateau;
using CantStop.Core.Gamer;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CantStop.Core.Dices;

namespace CantStop.Core.Game
{
    public class CantStopGameTurn
    {
        public RollResult CurrentRollResult { get; set; }
        private CantStopGame CurrentGame { get; set; }
        public int TurnNumber { get; }
        public CantStopGameTurn(int number)
        {
            TurnNumber = number;
        }
                
    }
}
