using CantStop.Core.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Board
{
    public interface IPlayableToken :IToken
    {
        IPlayer Owner { get; }

    }
}
