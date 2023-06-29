using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace interactive_tutorial.EntityMappings
{
    public class TestEntityMap : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.QuestionText);

            builder.HasOne(x => x.Answer);

            builder.HasOne(x => x.TrueAnswer);
        }
    }
}


