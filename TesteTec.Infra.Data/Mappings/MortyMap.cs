using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Infra.Data.Mappings
{
    public class MortyMap : IEntityTypeConfiguration<Morty>
    {
        public void Configure(EntityTypeBuilder<Morty> builder)
        {

        
           
            builder.Property(c => c.Id)
                .HasColumnName("Id");

        }
    }
}
