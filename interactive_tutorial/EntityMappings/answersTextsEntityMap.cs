using interactive_tutorial.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.EntityMappings
{
    public class answersTextsEntityMap : IEntityTypeConfiguration<answersTexts>
    {
        public void Configure(EntityTypeBuilder<answersTexts> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
    
}
