using CMDB_BackEnd.Domain.Config;
using Microsoft.EntityFrameworkCore;

namespace CMDB_BackEnd.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public const string ConnectionString = "CMDB";
        public const string Schema = "CMDB";
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);

            modelBuilder.ApplyConfiguration(new Actors_Config());

            modelBuilder.ApplyConfiguration(new Directors_Config());

            modelBuilder.ApplyConfiguration(new Genres_Config());

            modelBuilder.ApplyConfiguration(new Media_Config());

            modelBuilder.ApplyConfiguration(new Movie_Actors_Config());
            modelBuilder.ApplyConfiguration(new Movie_Config());
            modelBuilder.ApplyConfiguration(new Movie_Directors_Config());
            modelBuilder.ApplyConfiguration(new Movie_Genres_Config());

            modelBuilder.ApplyConfiguration(new Series_Actors_Config());
            modelBuilder.ApplyConfiguration(new Series_Config());
            modelBuilder.ApplyConfiguration(new Series_Directors_Config());
            modelBuilder.ApplyConfiguration(new Series_Genres_Config());

            modelBuilder.ApplyConfiguration(new TvShow_Actors_Config());
            modelBuilder.ApplyConfiguration(new TvShow_Config());
            modelBuilder.ApplyConfiguration(new TvShow_Directors_Config());
            modelBuilder.ApplyConfiguration(new TvShow_Genres_Config());



        }
    }
}
