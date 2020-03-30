using System;
using System.Collections.Generic;

namespace CantStop.Core.Lancer
{
    public class Combinaison
    {
        public Combinaison(int valeur1, int valeur2, int valeur3, int valeur4)
        {
            Paires = new Tuple<Paire, Paire>(new Paire(valeur1, valeur2),new Paire(valeur3, valeur4));
        }

        public Tuple<Paire, Paire> Paires { get; private set; }

    }
}