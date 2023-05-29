using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/directors")]
    public class CreateDirectors : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CreateDirectors(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateDirectors")]
        public async Task<object> CreateDirectorsReq([FromBody]string directorName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(directorName))
                    return BadRequest("The name should not be null");

                var director = new Directors(directorName);

                _context.Add(director);
                await _context.SaveChangesAsync();

                return Ok("Director added successfully");

            }
            catch (Exception ex) {

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the director" + ex) ;
            }

        }


    }
}
