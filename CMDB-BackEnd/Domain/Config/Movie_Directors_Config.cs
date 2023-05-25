using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Movie_Directors_Config : IEntityTypeConfiguration<Movie_Directors>
    {
        public void Configure(EntityTypeBuilder<Movie_Directors> b)
        {
           
            b.HasOne(p => p.Movies).WithMany(p => p.Movie_Directors).HasForeignKey(p => p.Movies_Id);
            b.HasOne(p => p.Directors).WithMany(p => p.Movie_Directors).HasForeignKey(p => p.Directors_Id);
        }
    }
}
