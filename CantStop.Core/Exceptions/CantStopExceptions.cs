using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Exceptions
{
    public class CantStopExceptions : Exception
    {
        public CantStopExceptions(string message): base(message)
        {

        }
    }
}
