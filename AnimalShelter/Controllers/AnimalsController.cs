using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers {
  public class AnimalsController: Controller {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db) {
      _db = db;
    }

    public ActionResult Index() {
      return View(_db.Animals.ToList());
    }

    public ActionResult Create() {
      ViewBag.BreedId = new SelectList(_db.Breeds, "BreedId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal Animal, int BreedId) {
      _db.Animals.Add(Animal);
      _db.SaveChanges();
      if (BreedId != 0) {
        _db.BreedAnimal.Add(new BreedAnimal() {
          BreedId = BreedId, AnimalId = Animal.AnimalId
        });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) {
      var thisAnimal = _db.Animals
        .Include(Animal => Animal.JoinEntities)
        .ThenInclude(join => join.Breed)
        .FirstOrDefault(Animal => Animal.AnimalId == id);
      return View(thisAnimal);
    }

    public ActionResult Edit(int id) {
      var thisAnimal = _db.Animals.FirstOrDefault(Animal => Animal.AnimalId == id);
      ViewBag.BreedId = new SelectList(_db.Breeds, "BreedId", "Name");
      return View(thisAnimal);
    }

    [HttpPost]
    public ActionResult Edit(Animal Animal, int BreedId) {
      if (BreedId != 0) {
        _db.BreedAnimal.Add(new BreedAnimal() {
          BreedId = BreedId, AnimalId = Animal.AnimalId
        });
      }
      _db.Entry(Animal).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisAnimal = _db.Animals.FirstOrDefault(Animal => Animal.AnimalId == id);
      return View(thisAnimal);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisAnimal = _db.Animals.FirstOrDefault(Animal => Animal.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddBreed(int id) {
      var thisAnimal = _db.Animals.FirstOrDefault(Animal => Animal.AnimalId == id);
      ViewBag.BreedId = new SelectList(_db.Breeds, "BreedId", "Name");
      return View(thisAnimal);
    }

    [HttpPost]
    public ActionResult AddBreed(Animal Animal, int BreedId) {
      if (BreedId != 0) {
        _db.BreedAnimal.Add(new BreedAnimal() {
          BreedId = BreedId, AnimalId = Animal.AnimalId
        });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteBreed(int joinId) {
      var joinEntry = _db.BreedAnimal.FirstOrDefault(entry => entry.BreedAnimalId == joinId);
      _db.BreedAnimal.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}