using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Data.Configurations
{
    internal class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            builder.ToTable("Beer");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
