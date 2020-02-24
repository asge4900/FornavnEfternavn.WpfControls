using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FornavnEfternavn.WpfControls.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FornavnEfternavn.WpfControls.Web.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieAsync(int id, MovieApiModel model)
        {
            var movie = new Movie
            {
                Id = model.Id,
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                Director = model.Director,
                IsColor = model.IsColor,
                Format = model.Format,
                Genre = model.Genre
            };

            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
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

        // POST: api/Movies
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovieAsync(MovieApiModel model)
        {
            var movie = new Movie
            {
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                Director = model.Director,
                IsColor = model.IsColor,
                Format = model.Format,
                Genre = model.Genre
            }; 

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            //return NoContent();

            return CreatedAtAction(nameof(GetMovieAsync), new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
