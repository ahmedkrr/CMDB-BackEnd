using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/series")]
    public class GetAllSeries : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        public GetAllSeries(ApplicationDbContext context) 
        { 
            _Context = context;
        }
        [HttpGet("GetAllSeries")]
        public async Task<object> GetAllSeriesReq()
        {
            try
            {
                var series = await _Context.Set<Series>()
                    .Include(c => c.Series_Actors)
                    .Include(c => c.Series_Directors)
                    .Include(c => c.Series_Genres)
                    .Select(c => new GetAllSeriesRequest
                    {
                        Series_Id = c.Series_Id,
                        Title = c.Title,
                        Release_Date = c.Release_Date.Year.ToString(),
                        OverView = c.OverView,
                        Poster_Url = c.Poster_Url,
                        Average_Rating = c.Average_Rating,
                        MediaTypes = c.MediaType.Media_Type_Name,

                        SeriesDirectors = c.Series_Directors.Select(c => new GetSeriesDirector
                        {
                            Directors_Name = c.Directors.Directors_Name
                        }).ToList(),

                        Series_Actors = c.Series_Actors.Select(c => new GetSeriesActors
                        {
                            Actor_Name = c.Actors.Actors_Name
                        }).ToList(),

                        SeriesGenres = c.Series_Genres.Select(c => new GetSeriesGenre
                        {
                            Series_genre = c.Genres.Genre_Name
                        }).ToList()

                    })
                .ToListAsync();

                return Ok(series);
            }
            catch
            (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
