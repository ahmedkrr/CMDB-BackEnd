using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/series")]
    public class CreateSeries : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CreateSeries(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("createseries")]
        public async Task<object> CreateSeriesReq(CreateSeriesRequest model)
        {
            var series = new Series();
            var seriesActors = new List<Series_Actors>();
            var seriesGenres = new List<Series_Genres>();
            var seriesDirectors = new List<Series_Directors>();

            try
            {
                if (string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.OverView) || model.Release_Date == DateTime.MinValue ||
                    model.MediaTypeId == 0 || model.Series_Directors_Id == null || model.Series_Actors_Id == null || model.Series_Genres_Id == null)
                {
                    return BadRequest("The Fields Should not be empty");
                }

                series = new Series(model.Title, model.Release_Date, model.OverView, model.Poster_Url, model.Average_Rating, model.MediaTypeId);

                _context.Add(series);
                await _context.SaveChangesAsync();

                seriesActors = model.Series_Actors_Id.Select(s => new Series_Actors(s, series.Series_Id)).ToList();
                _context.AddRange(seriesActors);

                seriesGenres = model.Series_Genres_Id.Select(s => new Series_Genres(s, series.Series_Id)).ToList();
                _context.AddRange(seriesGenres);

                seriesDirectors = model.Series_Directors_Id.Select(s => new Series_Directors(s, series.Series_Id)).ToList();
                _context.AddRange(seriesDirectors);

                await _context.SaveChangesAsync();

                return Ok("Series Created Successfully");
            }
            catch (Exception ex)
            {
                if (seriesDirectors != null)
                {
                    _context.RemoveRange(seriesDirectors);
                }
                if (seriesGenres != null)
                {
                    _context.RemoveRange(seriesGenres);
                    if (seriesActors != null)
                    {
                        _context.RemoveRange(seriesActors);
                    }
                    if (series != null)
                    {
                        _context.Remove(series);
                    }
                    await _context.SaveChangesAsync();

                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }
    }
}
