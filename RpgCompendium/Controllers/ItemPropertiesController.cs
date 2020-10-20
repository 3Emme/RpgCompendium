using Microsoft.AspNetCore.Mvc;
using RpgCompendium.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RpgCompendium.Controllers
{
  [Authorize(Roles = "Administrator")]
  public class ItemPropertiesController : Controller
  {
    private readonly RpgCompendiumContext _db;

    public ItemPropertiesController(RpgCompendiumContext db)
    {
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      List<ItemProperty> model = _db.ItemProperties.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(ItemProperty ItemProperty)
    {      
      _db.ItemProperties.Add(ItemProperty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisItemProperty = _db.ItemProperties
        .FirstOrDefault(ItemProperty => ItemProperty.ItemPropertyId == id);
      return View(thisItemProperty);
    }

    public ActionResult Edit(int id)
    {
      var thisItemProperty = _db.ItemProperties.FirstOrDefault(ItemProperty => ItemProperty.ItemPropertyId == id);
      return View(thisItemProperty);
    }

    [HttpPost]
    public ActionResult Edit(ItemProperty ItemProperty)
    {
      _db.Entry(ItemProperty).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisItemProperty = _db.ItemProperties.FirstOrDefault(ItemProperty => ItemProperty.ItemPropertyId == id);
      return View(thisItemProperty);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisItemProperty = _db.ItemProperties.FirstOrDefault(ItemProperty => ItemProperty.ItemPropertyId == id);
      _db.ItemProperties.Remove(thisItemProperty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}