using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private List<Animal> _animals = new MockDbAnimals().Animals;
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(s => s.Id == id);
        if (animal == null) return NotFound($"Animal with id {id} was not found");
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        return Created();
    }

    [HttpDelete("{Id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(s => s.Id == id);
        if (animal == null) return NotFound($"Animal with id {id} was not found");
        _animals.Remove(animal);
        return NoContent();
    }

    [HttpPut("{id:int})")]
    public IActionResult PutAnimal(int id, Animal newAnimal)
    {
        var animal = _animals.FirstOrDefault(s => s.Id == id);
        if (animal == null) return NotFound($"Animal with id {id} was not found");
        _animals.Remove(animal);
        _animals.Add(newAnimal);
        return NoContent();
    }
}