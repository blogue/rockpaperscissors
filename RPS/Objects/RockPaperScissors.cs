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

    public Game()
    {
      _player1wins = 0;
      _player2wins = 0;
      _gameInstances.Add(this);
      Console.WriteLine("new game created");
    }

    public void Turn(int player1choice, int player2choice)
    {
      if (player1choice == player2choice)
      {
        // return _wins;
      }
      else
      {
        if ((_rpsOptions[player1choice] == "rock" && _rpsOptions[player2choice] == "scissors") ||
            (_rpsOptions[player1choice] == "paper" && _rpsOptions[player2choice] == "rock") ||
            (_rpsOptions[player1choice] == "scissors" && _rpsOptions[player2choice] == "paper"))
        {
          _player1wins ++;
          // return _wins;
        }
        else
        {
          _player2wins ++;
          // return _wins;
        }
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
  }
}
