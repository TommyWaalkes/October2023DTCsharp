using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICreation.Models;

namespace APICreation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieDetailsController : ControllerBase
    {
        private readonly OmdbApiContext _context;

        public MovieDetailsController(OmdbApiContext context)
        {
            _context = context;
        }

        // GET: api/MovieDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDetail>>> GetMovieDetails()
        {
          if (_context.MovieDetails == null)
          {
              return NotFound();
          }
            return await _context.MovieDetails.ToListAsync();
        }

        // GET: api/MovieDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDetail>> GetMovieDetail(string id)
        {
          if (_context.MovieDetails == null)
          {
              return NotFound();
          }
            var movieDetail = await _context.MovieDetails.FindAsync(id);

            if (movieDetail == null)
            {
                return NotFound();
            }

            return movieDetail;
        }

        // PUT: api/MovieDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieDetail(string id, MovieDetail movieDetail)
        {
            if (id != movieDetail.ImdbId)
            {
                return BadRequest();
            }

            _context.Entry(movieDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieDetailExists(id))
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
        public async Task<ActionResult<MovieDetail>> PostMovieDetail(MovieDetail movieDetail)
        {
          if (_context.MovieDetails == null)
          {
              return Problem("Entity set 'OmdbApiContext.MovieDetails'  is null.");
          }
            _context.MovieDetails.Add(movieDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieDetailExists(movieDetail.ImdbId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMovieDetail", new { id = movieDetail.ImdbId }, movieDetail);
        }

        // DELETE: api/MovieDetails/5
        //Action parameters can only be int or strings, objects must be sent to endpoints via the request' body
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieDetail(string id)
        {
            if (_context.MovieDetails == null)
            {
                return NotFound();
            }
            var movieDetail = await _context.MovieDetails.FindAsync(id);
            if (movieDetail == null)
            {
                return NotFound();
            }

            _context.MovieDetails.Remove(movieDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieDetailExists(string id)
        {
            return (_context.MovieDetails?.Any(e => e.ImdbId == id)).GetValueOrDefault();
        }
    }
}
