using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    public class AnimalShelter : Controller
    {
            private readonly AnimalShelterContext _db;

    public AnimalShelterController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }

public ActionResult Create()
{
    return View();
}

[HttpPost]
public ActionResult Create(Animal animal)
{
    _db.Animals.Add(animals);
    _db.SaveChanges();
    return RedirectToAction("Index");
}

}
}
