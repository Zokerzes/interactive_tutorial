using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.EntityMappings
{
    public class TrueAnswersEntityMap : IEntityTypeConfiguration<TrueAnswers>
    {
        public void Configure(EntityTypeBuilder<TrueAnswers> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }

}