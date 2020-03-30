using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Plateau
{
    public class CantStopBoardGame : IBoardGame
    {
        public List<Colonne> Colonnes { get; private set; }

        public CantStopBoardGame()
        {
            Colonnes = new List<Colonne>();

            for (int i = 2; i <= 12; i++)
            {
                Colonnes.Add(new Colonne(i)); 
            }
        }


    }
}
