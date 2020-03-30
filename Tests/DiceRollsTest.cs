using CantStop.Core;
using CantStop.Core.Lancer;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class DiceRollsTest
    {
        [Fact]
        public void Test_always_true()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test_dices_rolled_should_always_be_4()
        {
            var lancer = LancerDes.Lancer();

            Assert.Equal(4, lancer.Count);
        }

        [Fact]
        public void Test_dices_rolled_value_should_always_be_between_1_and_6()
        {
            var lancer = LancerDes.Lancer();

            Assert.DoesNotContain(lancer, (d)=> d < 1 || d > 6);
        }

        [Fact]
        public void Test_result_should_have_3_pairs()
        {
            var resultat = new ResultatDesTest();

            Assert.Equal(3, resultat.Combinaisons.Count);
        }


        [Fact]
        public void Test_result_sum_of_each_pair_should_be_equal()
        {
            var resultat = new ResultatDesTest();
            int somme = resultat.Somme;
            Assert.True(resultat.Combinaisons.All(c => c.Paires.Item1.Somme + c.Paires.Item2.Somme == somme));
        }

        


    }
}
