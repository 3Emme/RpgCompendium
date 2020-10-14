using Microsoft.AspNetCore.Mvc;
using RpgCompendium.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RpgCompendium.Controllers
{
  public class MainTypesController : Controller
  {
    private readonly RpgCompendiumContext _db;

    public MainTypesController(RpgCompendiumContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<MainType> model = _db.MainTypes.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(MainType mainType)
    {
      _db.MainTypes.Add(mainType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMainType = _db.MainTypes
          // .Include(monster => monster.MonsterBehaviors)
          // .ThenInclude(join => join.MonsterBehaviors)
          .FirstOrDefault(mainType => mainType.MainTypeId == id);
      return View(thisMainType);
    }

    public ActionResult Edit(int id)
    {
      var thisMainType = _db.MainTypes.FirstOrDefault(mainType => mainType.MainTypeId == id);
      return View(thisMainType);
    }

    [HttpPost]
    public ActionResult Edit(MainType mainType)
    {
      _db.Entry(mainType).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMainType = _db.MainTypes.FirstOrDefault(mainType => mainType.MainTypeId == id);
      return View(thisMainType);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMainType = _db.MainTypes.FirstOrDefault(mainType => mainType.MainTypeId == id);
      _db.MainTypes.Remove(thisMainType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}