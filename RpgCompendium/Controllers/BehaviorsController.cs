using Microsoft.AspNetCore.Mvc;
using RpgCompendium.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RpgCompendium.Controllers
{
  public class BehaviorsController : Controller
  {
    private readonly RpgCompendiumContext _db;

    public BehaviorsController(RpgCompendiumContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Behavior> model = _db.Behaviors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Behavior behavior)
    {
      _db.Behaviors.Add(behavior);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBehavior = _db.Behaviors
          // .Include(monster => monster.MonsterBehaviors)
          // .ThenInclude(join => join.MonsterBehaviors)
          .FirstOrDefault(behavior => behavior.BehaviorId == id);
      return View(thisBehavior);
    }

    public ActionResult Edit(int id)
    {
      var thisBehavior = _db.Behaviors.FirstOrDefault(behavior => behavior.BehaviorId == id);
      return View(thisBehavior);
    }

    [HttpPost]
    public ActionResult Edit(Behavior behavior)
    {
      _db.Entry(behavior).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisBehavior = _db.Behaviors.FirstOrDefault(behavior => behavior.BehaviorId == id);
      return View(thisBehavior);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBehavior = _db.Behaviors.FirstOrDefault(behavior => behavior.BehaviorId == id);
      _db.Behaviors.Remove(thisBehavior);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}