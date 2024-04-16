using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal{Id = 1, Name = "Azor", Category= "Mamoth", Mass  = 1000, Color = "Blue"},
        new Animal{Id = 2, Name="Mal", Category="Snake",  Mass  = 0.5, Color = "Yellow"},
        new Animal{Id = 3, Name="Tan", Category="Coala",  Mass  = 15, Color = "Black"},
        new Animal{Id = 4, Name="Cris", Category="Teemo",  Mass  = 41, Color = "Blue"},
        new Animal{Id = 5, Name="Bla", Category="Pumba",  Mass  = 100, Color = "Purple"},
    };
}