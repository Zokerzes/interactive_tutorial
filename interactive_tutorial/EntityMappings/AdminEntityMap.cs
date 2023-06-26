using interactive_tutorial.Constants;
using interactive_tutorial.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace interactive_tutorial.EntityMappings
{
    internal class AdminEntityMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Login).IsUnique();

            builder.Property(x => x.Login).HasMaxLength(DefaultDB.STRING_VALUE_MAX_LENGTH);
        }
    }
}
