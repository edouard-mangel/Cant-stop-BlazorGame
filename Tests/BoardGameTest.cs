using CantStop.Core.Plateau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
    public class BoardGameTest
    {
        [Fact]
        public void Test_new_BoardGame_Has_11_columns()
        {
            var board = new CantStopBoardGame();

            Assert.Equal(11, board.Colonnes.Count);
        }

        [Fact]
        public void Test_new_BoardGame_Columns_Have_All_Different_numbers()
        {
            var board = new CantStopBoardGame();

            Assert.Equal(11, board.Colonnes.Select(c => c.Valeur).Distinct().Count());
        }

        [Fact]
        public void Test_new_BoardGame_Columns_Have_All_numbers_From_2_To_12()
        {
            var board = new CantStopBoardGame();

            Assert.Equal(2, board.Colonnes.OrderBy(c => c.Valeur).ToList().First().Valeur);
            Assert.Equal(12, board.Colonnes.OrderBy(c => c.Valeur).ToList().Last().Valeur);
        }


        [Fact]
        public void Test_new_BoardGame_Columns_Should_All_Be_Open()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.All(c => c.EstOuverte));
        }
        
        [Fact]
        public void Test_new_BoardGame_Columns_2_And_12_have_3_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.Where(col => col.Valeur == 2 || col.Valeur == 12).All(col => col.Cases.Count == 3));
        }

        [Fact]
        public void Test_new_BoardGame_Columns_3_And_11_have_5_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.Where(col => col.Valeur == 3 || col.Valeur == 11).All(col => col.Cases.Count == 5));
        }


        [Fact]
        public void Test_new_BoardGame_Columns_4_And_10_have_7_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.Where(col => col.Valeur == 4 || col.Valeur == 10).All(col => col.Cases.Count == 7));
        }


        [Fact]
        public void Test_new_BoardGame_Columns_5_And_9_have_9_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.Where(col => col.Valeur == 5 || col.Valeur == 9).All(col => col.Cases.Count == 9));
        }

        [Fact]
        public void Test_new_BoardGame_Columns_6_And_8_have_11_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.Where(col => col.Valeur == 6 || col.Valeur == 8).All(col => col.Cases.Count == 11));
        }

        [Fact]
        public void Test_new_BoardGame_Column_7_has_13_spots()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.First(col => col.Valeur == 7).Cases.Count == 11);
        }


        [Fact]
        public void Test_new_spot_is_empty()
        {
            var board = new CantStopBoardGame();

            Assert.True(board.Colonnes.SelectMany(c => c.Cases).All(caseJeu => caseJeu.EstVide));            
        }

        [Fact]
        public void Test_Cases_have_distinct_indices()
        {
            var board = new CantStopBoardGame();
            Assert.True(board.Colonnes.All(c => c.Cases.Count == c.Cases.Select(caseJeu => caseJeu.Indice).Distinct().Count()));
        }


    }
}
