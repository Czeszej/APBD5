using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsControllers : ControllerBase
{

    public static List<Animal> _animals = new()

    {
        new Animal (1, "Koko", "Pies", 10f, "Br¹zowo-czarny"),
        new Animal (2, "Loko", "Kot", 7.3f, "Bia³y"),
        new Animal (3, "Czoko", "Chomik", 0.3f, "Br¹zowo-bia³y")

    };


    //zwracanie zwierzat z zapytania http

    [HttpGet]


    public IActionResult GetAnimals() {
        return Ok(_animals);
    }


    [HttpGet("{id:int}")]
    public IActionResult GetAnimalByID(int id) {
        var animal = _animals.FirstOrDefault(animal => animal.id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} not found");
        }
        return Ok(animal);

    }

    [HttpPost]
    public IActionResult PostAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]

    public IActionResult PutAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(animal => animal.id == id);
        if (animalToEdit == null) {
            return NotFound($"Animal with id {id} not found");
        }
        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]

    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = _animals.FirstOrDefault(animal => animal.id == id);
        if (animalToDelete == null)
        {
            return NoContent();
        }
        _animals.Remove(animalToDelete);
        return NoContent();
    }
    
    //pobranie listy wizyt dla danego zwierzêcia.


}



    
