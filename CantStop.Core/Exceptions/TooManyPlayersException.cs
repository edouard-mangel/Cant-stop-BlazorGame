using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Exceptions
{
    public class TooManyPlayersException : CantStopExceptions
    {
        public TooManyPlayersException(string message): base(message)
        {
            
        }
    }
}
