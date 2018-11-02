using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Data.Configurations
{
    internal class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(512);
        }
    }
}
