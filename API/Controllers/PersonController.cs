using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;
    private readonly SocDbContext _db;

    public PersonController(ILogger<PersonController> logger, SocDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet("person")]
    public async Task<ActionResult<IEnumerable<Person>>> Get()
    {
        return await _db.People.AsNoTracking().ToListAsync();
    }
}
