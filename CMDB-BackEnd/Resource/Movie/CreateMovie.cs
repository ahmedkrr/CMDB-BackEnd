using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/Movie")]
    public class CreateMovie : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CreateMovie(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateMovie")]
        public async Task<object> CreateMovieReq(CreateMovieRequest model)
        {
            var movie =new Movie();
            var movieActors = new List<Movie_Actors>();
            var moviegenre = new List<Movie_Genres>();
            var movedirectors = new List<Movie_Directors>();

            try
            {
                if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.OverView) || model.Release_Date == DateTime.MinValue ||
                    model.MediaTypeId == 0 || model.Movie_Actors_Id == null || model.Movie_Genre_Id == null || model.Movie_Direcotr_Id == null)
                {
                    return BadRequest("The Fields Should not be empty");
                }

                 movie = new Movie(model.Title, model.Release_Date, model.OverView, model.Runtime, model.Poster_Url, model.Average_Rating, model.MediaTypeId);
                
                 _context.Add(movie);
                  await _context.SaveChangesAsync();

                 movieActors = model.Movie_Actors_Id.Select(s => new Movie_Actors(s, movie.Movie_Id)).ToList();
                _context.AddRange(movieActors);

                 moviegenre = model.Movie_Genre_Id.Select(s => new Movie_Genres(s, movie.Movie_Id)).ToList();
                _context.AddRange(moviegenre);

                 movedirectors = model.Movie_Direcotr_Id.Select(s => new Movie_Directors(s, movie.Movie_Id)).ToList();
                _context.AddRange(movedirectors);

                await _context.SaveChangesAsync();

                return Ok("Movie Created Successfully");
            }
            catch(Exception ex) 
            { 
                if(movedirectors != null)
                {
                    _context.RemoveRange(movedirectors);
                }
                if (moviegenre != null)
                {
                    _context.RemoveRange(moviegenre);
                }
                if (movieActors != null)
                {
                    _context.RemoveRange(movieActors);
                }
                if (movie != null)
                {
                    _context.Remove(movie);
                }
                await _context.SaveChangesAsync();

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }
    }
}
