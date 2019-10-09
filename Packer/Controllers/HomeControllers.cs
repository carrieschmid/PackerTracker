using Microsoft.AspNetCore.Mvc;
using Packer.Models;

namespace Packer.Controllers
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