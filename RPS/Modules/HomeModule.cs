using Nancy;
using RockPaperScissors.Objects;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {

    public HomeModule()
    {

      Get["/"] = _ => {
        Game userGame = new Game();
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Game userGame = Game.GetGame()[0];
        userGame.Turn(Request.Form["choice1"],Request.Form["choice2"]);
        return View["play.cshtml", userGame];
      };
      Get["/play"] = _ => {
        Game userGame = Game.GetGame()[0];
        return View["play.cshtml"];
      };
    }
  }
}
