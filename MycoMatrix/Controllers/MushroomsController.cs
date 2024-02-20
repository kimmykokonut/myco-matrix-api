using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MycoMatrix.Models;

namespace MycoMatrix.Controllers
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class MushroomsController : ControllerBase
  {
    private readonly MycoMatrixContext _db;

    public MushroomsController(MycoMatrixContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Mushroom>>> Get(
    string editor, 
    string commonName, 
    string genus, 
    string species, 
    string gillType, 
    [Range(0, 10)] int toxicityLevel, 
    [Range(1, int.MaxValue)] int page = 1, 
    [Range(1, 30)] int pageSize = 4)
    
    {
      if(!ModelState.IsValid)
      {
        return BadRequest();
      }
      IQueryable<Mushroom> query = _db.Mushrooms.OrderBy(m => m.MushroomId).AsQueryable();
      if (commonName != null)
      {
        query = query.Where(e => e.CommonName.Contains(commonName));
      }
      if (editor != null)
      {
        query = query.Where(e => e.Editor.Contains(editor));
      }
      if (genus != null)
      {
        query = query.Where(e => e.Genus == genus);
      }

      if (species != null)
      {
        query = query.Where(e => e.Species == species);
      }

      if (gillType != null)
      {
        query = query.Where(e => e.GillType == gillType);
      }

      if (toxicityLevel > -1)
      {
        query = query.Where(e => e.ToxicityLevel >= toxicityLevel);
      }

      return await query.Skip(pageSize * (page - 1)).Take(pageSize).ToListAsync();
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
    public async Task<IActionResult> DeleteMushroom(int id, string editor)
    {
      Mushroom m = await _db.Mushrooms.FindAsync(id);
      if (m == null)
      {
        return NotFound();
      }
      if (editor != m.Editor)
      {
        return Unauthorized();
      }
      
      _db.Mushrooms.Remove(m);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Mushroom m, string editor)
    {
      if (id != m.MushroomId)
      {
        return BadRequest();
      }
      if (editor != m.Editor)
      {
        return Unauthorized();
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

    [HttpPatch("{id}")]
    [ProducesResponseType(typeof(Mushroom), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> JsonPatchWithModelState(int id,
      [FromBody] JsonPatchDocument<Mushroom> patchDoc, string editor)
    {
      if (patchDoc != null)
      {
        Mushroom m = await _db.Mushrooms.FindAsync(id);

        if (m == null)
        {
          return NotFound();
        }
        
        if (editor != m.Editor)
        {
          return Unauthorized();
        }

        patchDoc.ApplyTo(m, ModelState);

        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState);
        }

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
        return Ok(m);
      }
      else
      {
        return BadRequest(ModelState);
      }
    }

    [HttpGet("/random")]
    public async Task<ActionResult<Mushroom>> Random()
    {
      int count = _db.Mushrooms.Count();
      int rnd = new Random().Next(count);
      return await _db.Mushrooms.Skip(rnd).FirstAsync();
    }
  }

}