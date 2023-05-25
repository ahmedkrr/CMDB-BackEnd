using CMDB_BackEnd.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMDB_BackEnd.Domain.Config
{
    public class Directors_Config : IEntityTypeConfiguration<Directors>
    {
        public void Configure(EntityTypeBuilder<Directors> b)
        {
            b.HasKey(c => c.Directors_Id);
            b.Property(p => p.Directors_Name).HasMaxLength(50).IsRequired(true);
            
        }
    }
}
