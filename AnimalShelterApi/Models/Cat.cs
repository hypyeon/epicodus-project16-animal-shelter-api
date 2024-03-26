using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    public string Sex { get; set; }
    public bool NeuteredSpayed { get; set; }
  }
}