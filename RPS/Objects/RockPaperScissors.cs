using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private static string[] _rpsOptions = {"rock", "paper", "scissors"};
    private int _player1wins;
    private int _player2wins;
    private static List<Game> _gameInstances = new List<Game> {};
    private List<string> _lastChoices = new List<string> { "none", "none"};
    private string _winLoseOrDraw;

    public Game()
    {
      _player1wins = 0;
      _player2wins = 0;
      _gameInstances.Add(this);
    }

    public void Turn(int player1choice, int player2choice)
    {
      _lastChoices[0] = _rpsOptions[player1choice];
      _lastChoices[1] = _rpsOptions[player2choice];
      if (player1choice != player2choice)
      {
        if ((_rpsOptions[player1choice] == "rock" && _rpsOptions[player2choice] == "scissors") ||
            (_rpsOptions[player1choice] == "paper" && _rpsOptions[player2choice] == "rock") ||
            (_rpsOptions[player1choice] == "scissors" && _rpsOptions[player2choice] == "paper"))
        {
          _player1wins ++;
          _winLoseOrDraw = "beats";
        }
        else
        {
          _player2wins ++;
          _winLoseOrDraw = "loses to";
        }
      }
      else
      {
        _winLoseOrDraw = "ties";
      }

    }

    public static List<Game> GetGame()
    {
      return _gameInstances;
    }

    public int GetPlayer1Wins()
    {
      return _player1wins;
    }

    public int GetPlayer2Wins()
    {
      return _player2wins;
    }

    public string GetGameOutcome()
    {
      return _lastChoices[0] + " " + _winLoseOrDraw + " " + _lastChoices[1];
    }
  }
}
