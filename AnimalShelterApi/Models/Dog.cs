using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Sex { get; set; }
    public string Age { get; set; }
    public bool NeuteredSpayed { get; set; }
  }
}