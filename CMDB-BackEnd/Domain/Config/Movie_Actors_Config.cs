using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace CMDB_BackEnd.Domain.Config
{
    public class Movie_Actors_Config : IEntityTypeConfiguration<Movie_Actors>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Movie_Actors> b)
        {
            
            b.HasOne(c => c.Movies).WithMany(c => c.Movie_Actors).HasForeignKey(c => c.Movies_Id);
            b.HasOne(c => c.Actors).WithMany(c => c.Movie_Actors).HasForeignKey(c => c.Actors_Id);
        }
    }
}
