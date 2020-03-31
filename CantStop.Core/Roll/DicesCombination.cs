using System;
using System.Collections.Generic;

namespace CantStop.Core.Dices
{
    public class DicesCombination
    {
        public DicesCombination(int valeur1, int valeur2, int valeur3, int valeur4)
        {
            Paires = new Tuple<DicePair, DicePair>(new DicePair(valeur1, valeur2),new DicePair(valeur3, valeur4));
        }

        public Tuple<DicePair, DicePair> Paires { get; private set; }

    }
}