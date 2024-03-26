using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>().HasData(
        new Dog { DogId = 1, Name = "Beanie", Breed = "Australian Cattle Dog mix", Sex = "Male", Age = "3 years (estimate)", NeuteredSpayed = true },
        new Dog { DogId = 2, Name = "Bronx", Breed = "American Staffordshire Terrier mix", Sex = "Male", Age = "Unknown", NeuteredSpayed = true },
        new Dog { DogId = 3, Name = "Russell", Breed = "American Staffordshire Terrir mix", Sex = "Male", Age = "2 years (estimate)", NeuteredSpayed = true },
        new Dog { DogId = 4, Name = "Two", Breed = "Bull Terrier mix", Sex = "Female", Age = "9 months", NeuteredSpayed = true },
        new Dog { DogId = 5, Name = "Loverboy", Breed = "Belgian Shepherd mix", Sex = "Male", Age = "18 months", NeuteredSpayed = true },
        new Dog { DogId = 6, Name = "Hera", Breed = "Border Collie mix", Sex = "Female", Age = "2 years (estimate)", NeuteredSpayed = true },
        new Dog { DogId = 7, Name = "Burrito", Breed = "Dachshund mix", Sex = "Female", Age = "8 weeks", NeuteredSpayed = false },
        new Dog { DogId = 8, Name = "King", Breed = "Husky mix", Age = "4 years (estimate)", NeuteredSpayed = true }
      );
      builder.Entity<Cat>().HasData(
        new Cat { CatId = 1, Name = "Orzo", Sex = "Male", NeuteredSpayed = true },
        new Cat { CatId = 2, Name = "Luna", Sex = "Female", NeuteredSpayed = true },
        new Cat { CatId = 3, Name = "Starling", Sex = "Female", NeuteredSpayed = true },
        new Cat { CatId = 4, Name = "Elvie", Sex = "Female", NeuteredSpayed = true }
      );
    }
  }
}