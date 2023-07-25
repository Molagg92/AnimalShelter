using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal 
  {
    //private static List<Animal> _animalInstance = new List<Animal> {};
    public int AnimalId {get; set;}
    public string Type { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string DateOfAdmittance { get; set; }
    public string FavoriteFood { get; set; }

  //  // public Animal(string type)
  //   {

  //     //_animalInstance = new List<Animal> {};
  //    //  Type = type;
      
      
  //   }

  }
}