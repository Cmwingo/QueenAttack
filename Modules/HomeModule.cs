using Nancy;
using QueenAttack.Objects;
using System.Collections.Generic;

namespace QueenAttack
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/can_attack"] = _ => {
        int queenX = Request.Query["queen_x"];
        int queenY = Request.Query["queen_y"];
        int attackPositionX = Request.Query["attack_x"];
        int attackPositionY = Request.Query["attack_y"];
        Queen attackingQueen = new Queen();
        bool canAttack = attackingQueen.CanAttack(queenX, queenY, attackPositionX, attackPositionY);
        return View["index.cshtml", canAttack];
      };
    }
  }
}
