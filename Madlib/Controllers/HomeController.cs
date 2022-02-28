using Madlib.Models;
using Microsoft.AspNetCore.Mvc;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Splash() { return View(); }

    [Route("/maryform")]
    public ActionResult MaryForm() { return View(); }

    [Route("/marymadlib")]
    public ActionResult MaryLetter (
      string noun1,
      string adj1,
      string verb1,
      string verb2,
      string noun2,
      string verb3,
      string noun3,
      string noun4,
      string verb4,
      string verb5
    )
    {
      MaryMadlibVariable myMadlibVariable = new MaryMadlibVariable();
      myMadlibVariable.Noun1 = noun1;
      myMadlibVariable.Adj1 = adj1;
      myMadlibVariable.Verb1 = verb1;
      myMadlibVariable.Verb2 = verb2;
      myMadlibVariable.Noun2 = noun2;
      myMadlibVariable.Verb3 = verb3;
      myMadlibVariable.Noun3 = noun3;
      myMadlibVariable.Noun4 = noun4;
      myMadlibVariable.Verb4 = verb4;
      myMadlibVariable.Verb5 = verb5;
      return View(myMadlibVariable);
    }

  }
}


