using CantStop.Core.Board;
using CantStop.Core.Gamer;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CantStop.Core.Exceptions;

namespace CantStop.Core.Gamer
{
    public class CantStopPlayer : IPlayer
    {
        public string Name { get; }
        public IPlayerLevel Level { get ; set ; }
        private List<CantStopPlayerToken> CantStopTokens { get; set; } = new List<CantStopPlayerToken>();
        List<IToken> IPlayer.Tokens => CantStopTokens.AsEnumerable<IToken>().ToList();
    
        public CantStopPlayer(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException("Player name should be set.");
            }
            else if (name.Trim().Length == 0)  
            {
                throw new ArgumentException("Player name should not be empty.");
            }
            Name = name;
        }


        public List<IToken> GetTokens() => CantStopTokens.AsEnumerable<IToken>().ToList();

        public void AddToken(IToken cantStopToken)
        {
            if (cantStopToken is null)
            {
                throw new NullReferenceException("Le jeton est null.");
            }
            if (cantStopToken.GetType() != typeof(CantStopPlayerToken))
            {
                throw new WrongTokenTypeException();
            }

            CantStopTokens.Add(cantStopToken as CantStopPlayerToken);
        }
    }
}
