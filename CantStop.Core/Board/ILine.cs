using System.Collections.Generic;

namespace CantStop.Core.Plateau
{
    public interface ILine
    {
        IEnumerable<IPosition> Positions { get; set; }
    }
}