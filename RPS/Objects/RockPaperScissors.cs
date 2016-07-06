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

    public void Turn(string player1choice, string player2choice)
    {
      _lastChoices[0] = player1choice;
      _lastChoices[1] = player2choice;
      if (player1choice != player2choice)
      {
        if ((player1choice == "rock" && player2choice == "scissors") ||
            (player1choice == "paper" && player2choice == "rock") ||
            (player1choice == "scissors" && player2choice == "paper"))
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
