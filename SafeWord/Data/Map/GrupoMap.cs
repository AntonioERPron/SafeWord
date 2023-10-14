﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rocypt.Models;

namespace Rocypt.Data.Map
{
    public class GrupoMap : IEntityTypeConfiguration<GrupoModel>
    {
        public void Configure(EntityTypeBuilder<GrupoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(15).IsRequired();
            builder.HasOne(x => x.Usuario);
        }
    }
}
