using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Exceptions
{
    public class WrongTokenTypeException : CantStopExceptions
    {
        public WrongTokenTypeException(): base("Wrong token type added, Can't Stop players can only own Can't Stop tokens.")
        {            

        }
    }
}
