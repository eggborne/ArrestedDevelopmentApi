using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArrestedDevelopmentApi.Models;

namespace ArrestedDevelopmentApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuotesController : ControllerBase
  {
    private readonly ArrestedDevelopmentApiContext _db;

    public QuotesController(ArrestedDevelopmentApiContext db)
    {
      _db = db;
    }

    // GET api/quotes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Quote>>> Get(string speaker, bool question = false)
    {
      IQueryable<Quote> query = _db.Quotes.AsQueryable();

      if (speaker != null)
      {
        query = query.Where(entry => entry.Speaker == speaker);
      }
      if (question)
      {  
        query = query.Where(entry => entry.Text.EndsWith("?"));
      }

      return await query.ToListAsync();
    }

    // GET: api/quotes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Quote>> GetQuote(int id)
    {
      Quote Quote = await _db.Quotes.FindAsync(id);

      if (Quote == null)
      {
        return NotFound();
      }

      return Quote;
    }

    // POST api/quotes
    [HttpPost]
    public async Task<ActionResult<Quote>> Post(Quote quote)
    {
      _db.Quotes.Add(quote);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetQuote), new { id = quote.QuoteId }, quote);
    }

    // PUT: api/Quotes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Quote quote)
    {
      if (id != quote.QuoteId)
      {
        return BadRequest();
      }

      _db.Quotes.Update(quote);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!QuoteExists(id))
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

    private bool QuoteExists(int id)
    {
      return _db.Quotes.Any(e => e.QuoteId == id);
    }
  }
}