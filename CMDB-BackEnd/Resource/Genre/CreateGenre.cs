using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/genre")]
    public class CreateGenre : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CreateGenre(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("createGenre")]
        public async Task<object> CreateGenreReq([FromBody]string genre)
        {
            try
            {
                if(string.IsNullOrEmpty(genre))
                {
                    return BadRequest("Genre Should not be null");
                }
                var Genre = new Genres(genre);

                _context.Add(Genre);
                await  _context.SaveChangesAsync();
                return Ok("Genre Created Successfully");


            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
