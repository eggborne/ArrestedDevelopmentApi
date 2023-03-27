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
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Quote>>> Get(string speaker, int maxWords, bool question = false)
    // {
    //   IQueryable<Quote> query = _db.Quotes.AsQueryable();

    //   if (speaker != null)
    //   {
    //     query = query.Where(entry => entry.Speaker == speaker);
    //   }
    //   if (question)
    //   {  
    //     query = query.Where(entry => entry.Text.EndsWith("?"));
    //   }
    //   if (maxWords != 0)
    //   {  
    //     query = query.Where(entry => entry.NumberOfWords <= maxWords);
    //   }

    //   return await query.ToListAsync();
    // }

    // Chat GPT $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

    [HttpGet]
    public IActionResult GetQuotes(int page = 1, int pageSize = 10)
    {
        // Calculate the number of items to skip based on the page size and requested page.
        int skip = (page - 1) * pageSize;

        // Retrieve the data from your data source, applying the pagination parameters.
        List<Quote> quotes = _db.Quotes
            .OrderBy(q => q.QuoteId)
            .Skip(skip)
            .Take(pageSize)
            .ToList();

        // Determine the total number of items in your data source.
        int totalCount = _db.Quotes.Count();

        // Create a response object to hold the paginated data and total count.
        var response = new
        {
            Data = quotes,
            TotalCount = totalCount,
            Page = page,
            PageSize = pageSize
        };

        // Return the paginated data to the client.
        return Ok(response);
    }

    // $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

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
      quote.NumberOfWords = quote.Text.Split(" ").Count();
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

    // DELETE: api/Quotes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteQuote(int id)
    {
      Quote Quote = await _db.Quotes.FindAsync(id);
      if (Quote == null)
      {
        return NotFound();
      }

      _db.Quotes.Remove(Quote);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool QuoteExists(int id)
    {
      return _db.Quotes.Any(e => e.QuoteId == id);
    }
  }
}