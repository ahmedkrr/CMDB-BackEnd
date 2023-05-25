using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Movie_Genres_Config : IEntityTypeConfiguration<Movie_Genres>
    {
        public void Configure(EntityTypeBuilder<Movie_Genres> b)
        {
            
            b.HasOne(c => c.Movie).WithMany(c => c.Movie_Genres).HasForeignKey(c => c.Movie_Id);
            b.HasOne(c => c.Genres).WithMany(c => c.Movie_Genres).HasForeignKey(c => c.Genres_Id);
        }
    }
}
