using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDbVisits
{
    public List<Visit> Visits { get; set; } = new List<Visit>();
    public MockDbVisits()
    {
        MockDbAnimals animals = new MockDbAnimals();
        Visits.Add(new Visit(){ VisitDay = new DateTime(2016, 12, 29), VisitingAnimal = animals.Animals[3], Cost = 56.31});
        Visits.Add(new Visit(){VisitDay = new DateTime(2024, 2, 25), VisitingAnimal = animals.Animals[0], Cost = 554});
        Visits.Add(new Visit(){VisitDay = new DateTime(2012, 6, 11), VisitingAnimal = animals.Animals[1], Cost = 135});
        Visits.Add(new Visit(){VisitDay = new DateTime(2006, 8, 1), VisitingAnimal = animals.Animals[0], Cost = 764});
    }
}