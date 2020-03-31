using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using CantStop.Core.Game;
using CantStop.Core.Plateau;
using CantStop.Core;
using System.Linq;
using CantStop.Core.Exceptions;
using CantStop.Core.Gamer;
using CantStop.Core.Board;

namespace Tests
{
    public class GameTest
    {
        public GameTest()
        {
            Game = new CantStopGame();
            player1 = new CantStopPlayer("Player1");
            player2 = new CantStopPlayer("Player2");
        }
        private CantStopGame Game { get; set; }
        private CantStopPlayer player1 { get; set; }
        private CantStopPlayer player2 { get; set; }

        [Fact]
        public void Test_New_Game_Has_Board()
        {
            Assert.NotNull(Game.Board);
            Assert.IsType<CantStopBoard>(Game.Board);
        }
        
        [Fact]
        public void Test_Game_Has_Defined_Players_when_given()
        {
            Game = new CantStopGame();
            Game.AddPlayer(player1);
            Game.AddPlayer(player2);

            Assert.Equal(2, Game.GetPlayers().Count);
            Assert.NotNull(Game.GetPlayers().FirstOrDefault(p=> p.Name.Equals(player1.Name)));
            Assert.NotNull(Game.GetPlayers().FirstOrDefault(p=> p.Name.Equals(player2.Name)));
        }

        [Fact]
        public void Test_Game_Cant_Add_Player_Multiple_Times()
        {
            Game.AddPlayer(player1);
            Game.AddPlayer(player2);
            Game.AddPlayer(player2);
            Game.AddPlayer(player2);
            Game.AddPlayer(player2);
            Game.AddPlayer(player2);

            Assert.Equal(2, Game.GetPlayers().Count);
            Assert.Equal(1, Game.GetPlayers().Count(p=> p.Name.Equals(player1.Name)));

            Assert.Equal(1, Game.GetPlayers().Count(p=> p.Name.Equals(player2.Name)));
        }

        [Fact]
        public void Test_New_Game_Has_Defined_Players_when_given_3()
        {
            var player3 = new CantStopPlayer("Player3");
            var player4 = new CantStopPlayer("Player4");
            var player5 = new CantStopPlayer("Player5");
            
            Game.AddPlayer(player1);
            Game.AddPlayer(player2);
            Game.AddPlayer(player3);
            Game.AddPlayer(player4);
            Assert.Throws<TooManyPlayersException>(()=> Game.AddPlayer(player5));
        }

        [Fact]
        public void Test_Game_should_have_minimum_2_Players_To_Start()
        {
            Game.AddPlayer(player1);

            Assert.Throws<NotEnoughPlayersException>(() => Game.StartGame());
            Game.AddPlayer(new CantStopPlayer("Player2"));
            Game.StartGame();
        }

        [Fact]
        public void Test_Game_Start_Starts_By_First_Turn()
        {
            
            Game.AddPlayer(player1);
            Game.AddPlayer(player2);

            Game.StartGame();
            Assert.Equal(1, Game.GetTurn());
        }

        [Fact]
        public void Test_Player_can_play_in_any_free_column()
        {
            Assert.Equal(Game.Board.GetColumns().ToList().Count, Game.GetPossibleCombinations(player1).Count);
        }

        [Fact]
        public void Test_Game_board_owns_three_neutral_tokens()
        {
            Assert.Equal(3, Game.Board.GetTokens().ToList().Count );
        }

        [Fact]
        public void Test_neutral_tokens_are_not_initially_set_as_played()
        {
            Assert.DoesNotContain((Game.Board as CantStopBoard).Tokens, t => (t as CantStopNeutralToken).IsPlayed);
        }
        
        [Fact]
        public void Test_neutral_token_is_played_when_1_pair_is_chosen()
        {
            
        }

        [Fact]
        public void Test_neutral_tokens_are_moved_when_2_pairs_are_chosen()
        {
            Assert.DoesNotContain((Game.Board as CantStopBoard).Tokens, t => (t as CantStopNeutralToken).IsPlayed);
        }

    }
}
