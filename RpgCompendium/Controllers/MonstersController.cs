using Microsoft.AspNetCore.Mvc;
using RpgCompendium.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
      return View();
    }

    [HttpPost]
    public ActionResult Create(Monster monster)
    {
      _db.Monsters.Add(monster);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMonster = _db.Monsters
          // .Include(monster => monster.MonsterBehaviors)
          // .ThenInclude(join => join.MonsterBehaviors)
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
  }
}