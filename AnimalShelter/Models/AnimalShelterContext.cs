using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models {
  public class AnimalShelterContext: DbContext {
    public DbSet <Breed> Breeds {get; set;}
    public DbSet <Animal> Animals {get; set;}
    public DbSet <BreedAnimal> BreedAnimal {get; set;}

    public AnimalShelterContext(DbContextOptions options): base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}