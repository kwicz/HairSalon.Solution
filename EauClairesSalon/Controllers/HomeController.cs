using Microsoft.AspNetCore.Mvc;

namespace EauClairesSalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}