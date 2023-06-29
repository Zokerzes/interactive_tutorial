using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace interactive_tutorial.EntityMappings
{
    public class TrueAnswerEntityMap : IEntityTypeConfiguration<TrueAnswer>
    {
        public void Configure(EntityTypeBuilder<TrueAnswer> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}