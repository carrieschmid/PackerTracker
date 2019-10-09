using Microsoft.AspNetCore.Mvc;
using Packer.Models;
using System.Collections.Generic;

namespace Packer.Controllers
{
  public class PackListController : Controller
  {
    [HttpGet("/packer")]
    public ActionResult Index()
    {
      List<PackList> newList = PackList.GetAll();
      return View(newList);
    }

    [HttpGet("/packer/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/packer")]
    public ActionResult Create(string item, bool isPurchased)
    {
      PackList newPackList = new PackList(item, isPurchased);
      if(isPurchased == false)
      {newPackList.IsPurchased = false;}
      else
      {newPackList.IsPurchased = true;}

      return RedirectToAction("Index");
    }

  }
}