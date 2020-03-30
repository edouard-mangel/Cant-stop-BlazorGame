using System;
using System.Collections.Generic;

namespace CantStop.Core
{
    public class LancerDes
    {
        public static List<UInt16> Lancer()
        {
            List<UInt16> resultatLancer = new List<ushort>();
            for (int i = 0; i < 4; i++)
            {
                resultatLancer.Add(Roll_Dice());
            }
            return resultatLancer; 
        }

        private static UInt16 Roll_Dice()
        {
            Random random = new Random();

            return (ushort)random.Next(minValue: 1, maxValue: 6);
        }

        

    }
}
