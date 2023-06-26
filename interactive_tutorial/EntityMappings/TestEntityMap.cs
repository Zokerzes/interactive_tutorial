using interactive_tutorial.Constants;
using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.EntityMappings
{
    public class TestEntityMap : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.QuestionsTexts);
            builder.HasOne(x => x.Answers);
            builder.HasOne(x => x.TrueAnswers);
        }
    }
}


