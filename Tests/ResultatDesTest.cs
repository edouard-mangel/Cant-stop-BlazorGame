using CantStop.Core.Dices;

namespace Tests
{
    internal class ResultatDesTest : RollResult
    {
        public ResultatDesTest() :base()
        {

        }
        public int Somme { get { return SommeLancers; } }
    }

}