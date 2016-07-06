using Xunit;
using RockPaperScissors.Objects;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class GameTest
  {
    [Fact]
    public void Game_ForP1RockP2Rock_draw()
    {
      var _testDict = new Dictionary<string, int> {};
      _testDict["player1"] = 0;
      _testDict["player2"] = 0;
      Game newGame = new Game();
      Assert.Equal(_testDict, newGame.Turn(0, 0));
      System.Console.WriteLine(_testDict["player1"] + " to " + _testDict["player2"]);
    }
  }
}
