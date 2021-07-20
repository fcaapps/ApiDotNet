using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Data.Mappings
{
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.RazaoSocial).HasMaxLength(100).IsRequired();
            builder.Property(x => x.NomeFantasia).HasMaxLength(100).IsRequired();            

        }
    }
}
