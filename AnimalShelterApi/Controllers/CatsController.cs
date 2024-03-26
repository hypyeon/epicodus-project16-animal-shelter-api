using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers;

[ApiController]
//[Route("api/[controller]")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
[ApiVersion("2.0")]
public class CatsController : ControllerBase
{
  private readonly AnimalShelterApiContext _db;
  public CatsController(AnimalShelterApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Cat>>> Get(string sex, bool? neuteredSpayed)
  {
    IQueryable<Cat> query = _db.Cats.AsQueryable();
    if (sex != null)
    {
      query = query.Where(e => e.Sex == sex);
    }
    if (neuteredSpayed.HasValue)
    {
      query = query.Where(e => e.NeuteredSpayed == neuteredSpayed.Value);
    }
    return await query.ToListAsync();
  }
  [HttpGet("{id}")]
  public async Task<ActionResult<Cat>> GetCat(int id)
  {
    Cat cat = await _db.Cats.FindAsync(id);
    if (cat == null)
    {
        return NotFound();
    }
    return cat;
  }
  [HttpPost]
  public async Task<ActionResult<Cat>> Post(Cat cat)
  {
    _db.Cats.Add(cat);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
  }
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, Cat cat)
  {
    if (id != cat.CatId)
    {
      return BadRequest();
    }
    _db.Cats.Update(cat);
    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!CatExists(id))
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
  private bool CatExists(int id)
  {
    return _db.Cats.Any(e => e.CatId == id);
  }
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteCat(int id)
  {
    Cat cat = await _db.Cats.FindAsync(id);
    if (cat == null)
    {
      return NotFound();
    }
    _db.Cats.Remove(cat);
    await _db.SaveChangesAsync();
    return NoContent();
  }
}
