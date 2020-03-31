using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Exceptions
{
    public class WrongPlayerTypeException : CantStopExceptions
    {
        public WrongPlayerTypeException(): base("Wrong player type added to the game.")
        {            
        }
    }
}
