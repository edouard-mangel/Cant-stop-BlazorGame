using CantStop.Core.Gamer;
using CantStop.Core.Plateau;
using System.Collections.Generic;

namespace CantStop.Core.Game
{
    public interface IBoardGame
    {
        IBoard Board { get; }
        int GetTurn();
        void StartGame();
        List<IPlayer> GetPlayers();
        void AddPlayer(IPlayer p);
    }
}