using Nancy;
// using QueenAttack.Objects;
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
    }
  }
}
