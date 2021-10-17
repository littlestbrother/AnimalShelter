namespace AnimalShelter.Models {
  public class BreedAnimal {
    public int BreedAnimalId {get; set;}
    public int AnimalId {get; set;}
    public int BreedId {get; set;}
    public virtual Animal Animal {get; set;}
    public virtual Breed Breed {get; set;}
  }
}