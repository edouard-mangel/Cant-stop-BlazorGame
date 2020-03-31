using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CantStop.Core.Gamer;
using System.Linq;
using CantStop.Core.Board;

namespace Tests
{
    public class PlayerTest
    {
        [Fact]
        public void Test_Player_Has_Name()
        {
            string playerName = "John Doe";
            var CantStopPlayer = new CantStopPlayer(playerName);
            Assert.Equal(playerName, CantStopPlayer.Name);
        }

        [Fact]
        public void Test_null_name_throws_nullexception()
        {
            Assert.Throws<ArgumentNullException>(() => new CantStopPlayer(null));
        }

        [Fact]
        public void Test_invalid_name_throws_exception()
        {
            Assert.Throws<ArgumentException>(() => new CantStopPlayer(string.Empty));
        }

        [Fact]
        public void Test_New_Player_has_no_token()
        {
            string playerName = "John Doe";
            var player = new CantStopPlayer(playerName);
            Assert.False(player.GetTokens().Any());
        }

        [Fact]
        public void Test_New_Player_can_add_tokens()
        {
            string playerName = "John Doe";
            var player = new CantStopPlayer(playerName);
            player.AddToken(new CantStopPlayerToken(player));
            Assert.Single(player.GetTokens());            
        }

        

    }
}
