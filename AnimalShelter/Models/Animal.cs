using System.Collections.Generic;

namespace AnimalShelter.Models {
  public class Animal {
    public Animal() {
      this.JoinEntities = new HashSet < BreedAnimal > ();
    }

    public int AnimalId {get; set;}
    public string Name {get; set;}
    public int Year {get; set;}
    public virtual ICollection < BreedAnimal > JoinEntities {
      get;
    }
  }
}