using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class LicensesController : Controller
  {
    private readonly FactoryContext _db;

    public LicensesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Licenses.ToList());
    }

    public ActionResult Details(int id)
    {
      License thisLicense = _db.Licenses
          .Include(Licenses => license.JoinEntities)
          .ThenInclude(join => join.Engineer)
          .FirstOrDefault(license => license.LicenseId == id);
      return View(thisLicense);
    }
  }
}
