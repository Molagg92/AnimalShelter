using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal 
  {
    //private static List<Animal> _animalInstance = new List<Animal> {};
    public string TypeId { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
    public string DateOfAdmittance { get; set; }
    public string FavoriteFood { get; set; }

  //  // public Animal(string type)
  //   {

  //     //_animalInstance = new List<Animal> {};
  //    //  Type = type;
      
      
  //   }

  }
}