using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;


namespace AnimalShelter.Controllers {
  public class BreedsController: Controller {
    private readonly AnimalShelterContext _db;

    public BreedsController(AnimalShelterContext db) {
      _db = db;
    }

    public ActionResult Index() {
      List < Breed > model = _db.Breeds.ToList();
      return View(model);
    }

    public ActionResult Create() {
      ViewBag.BreedId = new SelectList(_db.Breeds, "BreedId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Breed Breed) {
      _db.Breeds.Add(Breed);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) {
      var thisBreed = _db.Breeds
        .Include(Breed => Breed.JoinEntities)
        .ThenInclude(join => join.Animal)
        .FirstOrDefault(Breed => Breed.BreedId == id);
      return View(thisBreed);
    }

      public ActionResult Edit(int id) {
      var thisBreed = _db.Breeds.FirstOrDefault(Breed => Breed.BreedId == id);
      return View(thisBreed);
    }

    [HttpPost]
    public ActionResult Edit(Breed Breed) {
      _db.Entry(Breed).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisBreed = _db.Breeds.FirstOrDefault(Breed => Breed.BreedId == id);
      return View(thisBreed);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisBreed = _db.Breeds.FirstOrDefault(Breed => Breed.BreedId == id);
      _db.Breeds.Remove(thisBreed);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}