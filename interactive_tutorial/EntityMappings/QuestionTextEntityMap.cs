using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace interactive_tutorial.EntityMappings
{
    public class QuestionTextEntityMap : IEntityTypeConfiguration<QuestionText>
    {
        public void Configure(EntityTypeBuilder<QuestionText> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
