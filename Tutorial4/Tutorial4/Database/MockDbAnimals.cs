using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDbAnimals
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDbAnimals()
    {
        Animals.Add(new Animal(){Id = 1, Name = "Azor", Category= "Mamoth", Mass  = 1000, Color = "Blue"});
        Animals.Add(new Animal(){Id = 2, Name="Mal", Category="Snake",  Mass  = 0.5, Color = "Yellow"});
        Animals.Add(new Animal(){Id = 3, Name="Tan", Category="Coala",  Mass  = 15, Color = "Black"});
        Animals.Add(new Animal(){Id = 4, Name="Cris", Category="Teemo",  Mass  = 41, Color = "Blue"});
    }
}