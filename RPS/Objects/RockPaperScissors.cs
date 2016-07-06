using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private static string[] _rpsOptions = {"rock", "paper", "scissors"};
    private Dictionary<string, int> _wins = new Dictionary<string, int> {};

    public Game()
    {
      _wins["player1"] = 0;
      _wins["player2"] = 0;
    }

    public Dictionary<string, int> Turn(int player1choice, int player2choice)
    {
      if (player1choice == player2choice)
      {
        return _wins;
      }
      else
      {
        if ((_rpsOptions[player1choice] == "rock" && _rpsOptions[player2choice] == "scissors") ||
            (_rpsOptions[player1choice] == "paper" && _rpsOptions[player2choice] == "rock") ||
            (_rpsOptions[player1choice] == "scissors" && _rpsOptions[player2choice] == "paper"))
        {
          _wins["player1"] ++;
          return _wins;
        }
        else
        {
          _wins["player2"] ++;
          return _wins;
        }
      }
    }

  }
}
