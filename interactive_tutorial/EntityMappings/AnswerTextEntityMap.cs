using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace interactive_tutorial.EntityMappings
{
    public class AnswerTextEntityMap : IEntityTypeConfiguration<AnswerText>
    {
        public void Configure(EntityTypeBuilder<AnswerText> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
