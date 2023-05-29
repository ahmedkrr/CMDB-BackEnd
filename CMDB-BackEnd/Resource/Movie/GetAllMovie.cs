using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/Movie")]
    public class GetAllMovie : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        public GetAllMovie(ApplicationDbContext context) 
        {
            _Context = context; 
        }

        [HttpGet("GetAllMovie")]
        public async Task<object> GetAllMovieReq()
        {
            try
            {
                var movies = await _Context.Set<Movie>()
                    .Include(c => c.Movie_Actors)
                    .Include(c => c.Movie_Directors)
                    .Include(c => c.Movie_Genres)
                    .Select(c => new GetAllMovieRequest
                    {
                        Movie_Id = c.Movie_Id,
                        Title = c.Title,
                        Release_Date = c.Release_Date.Year.ToString(),
                        OverView = c.OverView,
                        Runtime = c.Runtime,
                        Poster_Url = c.Poster_Url,
                        Average_Rating = c.Average_Rating,
                        MediaTypes = c.MediaType.Media_Type_Name,

                        MovieDirectors = c.Movie_Directors.Select(c => new GetMovieDirector
                        {
                            Directors_Name = c.Directors.Directors_Name
                        }).ToList(),

                        Movie_Actors = c.Movie_Actors.Select(c => new GetMovieActors
                        {
                            Actor_Name = c.Actors.Actors_Name
                        }).ToList(),

                        MovieGenres = c.Movie_Genres.Select(c => new GetMovieGenre
                        {
                            Movie_genre = c.Genres.Genre_Name
                        }).ToList()

                    })
                .ToListAsync();

                return movies;
            }
            catch 
            (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
          
        }

    }
}
