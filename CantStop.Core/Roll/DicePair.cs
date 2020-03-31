using System;

namespace CantStop.Core.Dices
{
    public class DicePair
    {
        public Tuple<int, int> valeurs { get; }
        public int Somme { get => valeurs.Item1 + valeurs.Item2; }

        public DicePair(int valeur1, int valeur2)
        {
            valeurs = new Tuple<int, int>(valeur1, valeur2);
        }
    }
}