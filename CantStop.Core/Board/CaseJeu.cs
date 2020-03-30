using System;
using System.Collections.Generic;
using System.Text;

namespace CantStop.Core.Plateau
{
    public class CaseJeu
    {
        public bool EstVide { get; private set; }
        public int Indice { get; private set; }
        public CaseJeu(int i)
        {
            EstVide = true;
            Indice = i;
        }

    }
}
