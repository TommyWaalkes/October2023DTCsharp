using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntroFullStackAPI.Model;

namespace IntroFullStackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieDetailsController : ControllerBase
    {
        private readonly MovieContext _context;

        public MovieDetailsController(MovieContext context)
        {
            _context = context;
        }

        // GET: api/MovieDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDetails>>> GetMovieDetails()
        {
          if (_context.MovieDetails == null)
          {
              return NotFound();
          }
            return await _context.MovieDetails.ToListAsync();
        }

        // GET: api/MovieDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDetails>> GetMovieDetails(int id)
        {
          if (_context.MovieDetails == null)
          {
              return NotFound();
          }
            var movieDetails = await _context.MovieDetails.FindAsync(id);

            if (movieDetails == null)
            {
                return NotFound();
            }

            return movieDetails;
        }

        // PUT: api/MovieDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieDetails(int id, MovieDetails movieDetails)
        {
            if (id != movieDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieDetailsExists(id))
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

        // POST: api/MovieDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieDetails>> PostMovieDetails(MovieDetails movieDetails)
        {
          if (_context.MovieDetails == null)
          {
              return Problem("Entity set 'MovieContext.MovieDetails'  is null.");
          }
            _context.MovieDetails.Add(movieDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieDetails", new { id = movieDetails.Id }, movieDetails);
        }

        // DELETE: api/MovieDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieDetails(int id)
        {
            if (_context.MovieDetails == null)
            {
                return NotFound();
            }
            var movieDetails = await _context.MovieDetails.FindAsync(id);
            if (movieDetails == null)
            {
                return NotFound();
            }

            _context.MovieDetails.Remove(movieDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieDetailsExists(int id)
        {
            return (_context.MovieDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
