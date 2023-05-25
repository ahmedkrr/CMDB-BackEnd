using CMDB_BackEnd.Domain;
using CMDB_BackEnd.Domain.Data;
using CMDB_BackEnd.Model;
using Microsoft.AspNetCore.Mvc;

namespace CMDB_BackEnd.Resource
{
    [ApiController]
    [Route("api/Actor")]
    public class CreateActor : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public CreateActor(ApplicationDbContext context)
        {
            _context = context;
        }    

        [HttpPost("CreateActor")]
        public async Task<object> CreateActorReq([FromBody]CreateActorRequest model)
        {
            if (string.IsNullOrEmpty(model.Actors_Name) || string.IsNullOrEmpty(model.Biography) || model.Date_of_Birdth == DateTime.MinValue)
                return BadRequest("The Field Shloud not be empty");

            var actor = new Actors(model.Actors_Name, model.Date_of_Birdth, model.Biography, model.Profile_Pic);

            if(actor != null)
            {
                _context.Add(actor);
                await _context.SaveChangesAsync();

                return Ok(actor.Actors_Name + " Created Successfully");
            }

            return BadRequest();
        }
    }
}
