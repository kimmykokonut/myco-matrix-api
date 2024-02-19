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
    // POST api/mushrooms
    [HttpPost]
    public async Task<ActionResult<Mushroom>> Post(Mushroom m)
    {
      _db.Mushrooms.Add(m);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetMushroom), new { id = m.MushroomId }, m);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMushroom(int id)
    {
      Mushroom m = await _db.Mushrooms.FindAsync(id);
      if (m == null)
      {
        return NotFound();
      }
      _db.Mushrooms.Remove(m);
      await _db.SaveChangesAsync();

      return NoContent();

    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Mushroom m)
    {
      if (id != m.MushroomId)
      {
        return BadRequest();
      }
      _db.Mushrooms.Update(m);
      
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MushroomExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool MushroomExists(int id)
    {
      return _db.Mushrooms.Any(e => e.MushroomId == id);
    }


  }

}