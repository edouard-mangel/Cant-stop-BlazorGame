using CantStop.Core.Board;
using System.Collections.Generic;

namespace CantStop.Core.Plateau
{
    public interface IBoard
    {
        IEnumerable<IColumn> GetColumns();
        IEnumerable<ILine> GetLines();
        IEnumerable<IToken> GetTokens();
    }
}