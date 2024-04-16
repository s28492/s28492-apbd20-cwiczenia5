using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/visits-controller")]
public class VisitController: ControllerBase
{
    private List<Visit> _visits = new MockDbVisits().Visits;
    
    [HttpGet("{animalId:int}")]
    public IActionResult GetAnimalVisits(int animalId)
    {
        return Ok(_visits.Where((visit) => visit.VisitingAnimal.Id == animalId));
    }

    [HttpPost("Add_Visit")]
    public IActionResult AddVisit(Visit visit)
    {
        _visits.Add(visit);
        
        return Created();
    }
}