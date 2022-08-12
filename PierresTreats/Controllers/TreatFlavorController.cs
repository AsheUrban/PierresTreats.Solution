using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresTreats.Controllers
{
  public class TreatFlavorController : Controller
  {
    private readonly PierresTreatsContext _db;

    public TreatFlavorController(PierresTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "View All Treats and Flavors";
      List<TreatFlavor> model = _db.TreatFlavor.ToList();
      return View(model);
    }

    [HttpPost]
    public ActionResult Create(TreatFlavor treatflavor)
    {
      if (_db.TreatFlavor.FirstOrDefault(
              tr => tr.FlavorId == treatflavor.FlavorId && 
                    tr.TreatId == treatflavor.TreatId) == null)
      {
        _db.TreatFlavor.Add(treatflavor);
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}
