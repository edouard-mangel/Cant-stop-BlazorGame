using CantStop.Core.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Gamer
{
    public interface IPlayer
    {
        string Name { get; }
        IPlayerLevel Level { get; set; }
        List<IToken> Tokens { get; }

    }
}
