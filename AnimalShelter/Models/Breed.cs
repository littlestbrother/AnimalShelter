using System.Collections.Generic;

namespace AnimalShelter.Models {
  public class Breed {
    public Breed() {
      this.JoinEntities = new HashSet < BreedAnimal > ();
    }

    public int BreedId {get; set;}
    public string Name {get; set;}
    public virtual ICollection < BreedAnimal > JoinEntities {get; set;}
  }
}