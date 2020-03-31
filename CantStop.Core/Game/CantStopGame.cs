using CantStop.Core.Exceptions;
using CantStop.Core.Plateau;
using CantStop.Core.Gamer;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CantStop.Core.Dices;

namespace CantStop.Core.Game
{
    public class CantStopGame : IBoardGame
    {
        private CantStopBoard _board { get; set; }
        public IBoard Board { get { return _board; } private set { _board = value as CantStopBoard; } }
        public List<IPlayer> GetPlayers() => CantStopPlayers.AsEnumerable<IPlayer>().ToList();
        private List<CantStopPlayer> CantStopPlayers { get; set; } = new List<CantStopPlayer>();
        private List<CantStopGameTurn> GameTurns { get; } = new List<CantStopGameTurn>();
        public CantStopGameTurn CurrentTurn => GameTurns.Last();
        public int GetTurn() => CurrentTurn.TurnNumber;

        public RollResult rollResult { get; set; }

        public CantStopGame()
        {
            _board = new CantStopBoard();
        }

        public void AddPlayer(CantStopPlayer _player)
        {
            if (CantStopPlayers.Count == 4)
            {
                throw new TooManyPlayersException("Le nombre maximum de joueurs est déjà atteint.");
            }
            if (CantStopPlayers.Any(p => p.Name.ToUpperInvariant().Equals(_player.Name.ToUpperInvariant())))
            {
                return;
            }
            CantStopPlayers.Add(_player);
        }

        public void AjouterJoueursDefaut()
        {
            CantStopPlayers.Add(new CantStopPlayer("Player1"));
            CantStopPlayers.Add(new CantStopPlayer("Player2"));
        }

        public void StartGame()
        {
            if (CantStopPlayers.Count < 2)
            {
                throw new NotEnoughPlayersException();
            }
            GameTurns.Add(new CantStopGameTurn(1));
        }

        public void AddPlayer(IPlayer p)
        {
            if (!(p is CantStopPlayer))
            {
                throw new WrongPlayerTypeException();
            };
            AddPlayer((CantStopPlayer)p);
        }

        public List<Colonne> GetPossibleCombinations(CantStopPlayer player)
        {
            return _board.Colonnes;
        }
    }
}
