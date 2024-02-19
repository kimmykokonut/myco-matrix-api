using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MycoMatrix.Models;

namespace MycoMatrix.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class MushroomsController : ControllerBase
  {
    private readonly MycoMatrixContext _db;

    public MushroomsController(MycoMatrixContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Mushroom>>> Get()
    {
      return await _db.Mushrooms.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Mushroom>> GetMushroom(int id)
    {
      Mushroom m = await _db.Mushrooms.FindAsync(id);
      if (m == null)
      {
        return NotFound();
      }
      return m;
    }

  }

}