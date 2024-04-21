using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/visits")]
[ApiController]

public class VisitsController : ControllerBase
{

    public static List<Visit> _visits = new() {
        new Visit (1, new DateTime(2022, 3, 2), "szczepienie", 100 ),
        new Visit (1, new DateTime(2023, 5, 26), "Gips", 350.50f)
    };



    [HttpGet("{id:int}")]

    public IActionResult GetVisitByID(int id) 
    {
        var visit = _visits.FindAll(visit => visit.animal.id == id); 
        if (visit == null)
        {
            return NotFound($"Animal with id {id} not found");
        }
        return Ok(visit);

    }

    //
    [HttpPost]
    public IActionResult CreateVisitById([FromBody] Visit visit) { 
    
        _visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);

    }

    
}
