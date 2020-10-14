using Microsoft.AspNetCore.Mvc;
using RpgCompendium.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RpgCompendium.Controllers
{
  public class MonstersController : Controller
  {
    private readonly RpgCompendiumContext _db;

    public MonstersController(RpgCompendiumContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Monster> model = _db.Monsters.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.MainTypeId = new SelectList(_db.MainTypes, "MainTypeId", "MainTypeName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Monster monster, int MainTypeId)
    {
      _db.Monsters.Add(monster);
      if (MainTypeId != 0)
      {
        _db.MonsterMainTypes.Add(new MonsterMainType() { MainTypeId = MainTypeId, MonsterId = monster.MonsterId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMonster = _db.Monsters
          .Include(monster => monster.MainTypes)
          .ThenInclude(join => join.MainType)
          .FirstOrDefault(monster => monster.MonsterId == id);
      return View(thisMonster);
    }

    public ActionResult Edit(int id)
    {
      var thisMonster = _db.Monsters.FirstOrDefault(monster => monster.MonsterId == id);
      return View(thisMonster);
    }

    [HttpPost]
    public ActionResult Edit(Monster monster)
    {
      _db.Entry(monster).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMonster = _db.Monsters.FirstOrDefault(monster => monster.MonsterId == id);
      return View(thisMonster);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMonster = _db.Monsters.FirstOrDefault(monster => monster.MonsterId == id);
      _db.Monsters.Remove(thisMonster);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddMainType(int id)
    {
      var thisMonster = _db.Monsters.FirstOrDefault(monsters => monsters.MonsterId == id);
      ViewBag.MainTypeId = new SelectList(_db.MainTypes, "MainTypeId", "MainTypeName");
      return View(thisMonster);
    }
    [HttpPost]
    public ActionResult AddMainType(Monster monster, int MainTypeId)
    {
      if (MainTypeId != 0)
      {
        _db.MonsterMainTypes.Add(new MonsterMainType() { MainTypeId = MainTypeId, MonsterId = monster.MonsterId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = monster.MonsterId });
    }
    [HttpPost]
    public ActionResult DeleteMainType(int monsterId, int joinId)
    {
      var joinEntry = _db.MonsterMainTypes.FirstOrDefault(entry => entry.MonsterMainTypeId == joinId);
      _db.MonsterMainTypes.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = monsterId });
    }
  }
}