using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Exceptions
{
    public class NotEnoughPlayersException : CantStopExceptions
    {
        public NotEnoughPlayersException(): base("Not enough players to start game yet.")
        {
            
        }
    }
}
