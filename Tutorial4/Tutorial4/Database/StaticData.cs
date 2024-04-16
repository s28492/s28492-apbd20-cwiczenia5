using System.Runtime.InteropServices.JavaScript;
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

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit() { VisitDay = new DateTime(2016, 12, 29), VisitingAnimal = animals[3], Cost = 56.31 },
        new Visit() { VisitDay = new DateTime(2024, 2, 25), VisitingAnimal = animals[4], Cost = 554 },
        new Visit() { VisitDay = new DateTime(2012, 6, 11), VisitingAnimal = animals[1], Cost = 135 },
        new Visit() { VisitDay = new DateTime(2006, 8, 1), VisitingAnimal = animals[3], Cost = 764 },
        new Visit() { VisitDay = new DateTime(2020, 10, 8), VisitingAnimal = animals[3], Cost = 12 }
    };
}