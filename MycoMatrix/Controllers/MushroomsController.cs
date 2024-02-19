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

  }

}