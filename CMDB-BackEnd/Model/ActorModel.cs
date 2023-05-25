using System.ComponentModel.DataAnnotations;

namespace CMDB_BackEnd.Model
{
    public class ActorModel
    {
    }
    public class CreateActorRequest
    {   
        public required string Actors_Name { get; set; }

        public DateTime Date_of_Birdth { get; set; }

        public required string Biography { get; set; }

        public string? Profile_Pic { get;  set; }


    }

}
