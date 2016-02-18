using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleScoreNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ =>
      {
        string word = Request.Form["new-word"];
        ScrabbleScore play = new ScrabbleScore();
        return View["result.cshtml", play.Score(word)];
      };
    }
  }
}
