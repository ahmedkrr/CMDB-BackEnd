using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/MediaType")]
    public class CreateMediaType : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CreateMediaType(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateMediaType")]
        public async Task<object> CreateMediaTypeReq([FromBody]MediaTypeModelCreateRequest mediatype)
        {
            try
            {
                if (string.IsNullOrEmpty(mediatype.MediaTypeName))
                {
                    return BadRequest("The media Type should not be null");
                }

                var mediaType = new MediaType(mediatype.MediaTypeName);
                _context.Add(mediaType);
                await _context.SaveChangesAsync();

                return Ok("Media Type  Created Successfully");
            }
            catch (Exception ex) 
            { 
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}