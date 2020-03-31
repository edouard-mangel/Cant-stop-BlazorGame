using CantStop.Core.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Plateau
{
    public class CantStopBoard : IBoard
    {
        public List<Colonne> Colonnes { get; private set; }
        private List<CantStopNeutralToken> _tokens = new List<CantStopNeutralToken>();

        public IEnumerable<IToken> Tokens
        {
            get { return _tokens; }
            set { _tokens = value as List<CantStopNeutralToken>; }
        }

        public CantStopBoard()
        {
            Colonnes = new List<Colonne>();

            for (int i = 2; i <= 12; i++)
            {
                Colonnes.Add(new Colonne(i)); 
            }

            for (int i = 0; i < 3; i++)
            {
                _tokens.Add(new CantStopNeutralToken());
            }
        }

        public IEnumerable<IColumn> GetColumns()
        {
            return Colonnes;
        }

        public IEnumerable<ILine> GetLines()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IToken> GetTokens()
        {
            return Tokens;
        }
    }
}
