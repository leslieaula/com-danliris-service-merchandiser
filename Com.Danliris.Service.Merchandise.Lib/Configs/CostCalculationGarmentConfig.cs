﻿using Com.Danliris.Service.Merchandiser.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Com.Danliris.Service.Merchandiser.Lib.Configs
{
    public class CostCalculationGarmentConfig : IEntityTypeConfiguration<CostCalculationGarment>
    {
        public void Configure(EntityTypeBuilder<CostCalculationGarment> builder)
        {
            builder.Property(c => c.Code).HasMaxLength(100);
            builder.Property(c => c.RO_Number).HasMaxLength(100);
            builder.Property(c => c.Article).HasMaxLength(500);
            builder.Property(c => c.Convection).HasMaxLength(500);
            builder.Property(c => c.Commodity).HasMaxLength(500);
            builder.Property(c => c.Section).HasMaxLength(500);
            builder.Property(c => c.SizeRange).HasMaxLength(500);
            builder.Property(c => c.BuyerName).HasMaxLength(500);
            builder.Property(c => c.Description).HasMaxLength(3000);
            builder.Property(c => c.CommodityDescription).HasMaxLength(3000);
            builder.Ignore(c => c.ImageFile);
            builder
                .HasMany(c => c.CostCalculationGarment_Materials)
                .WithOne(cm => cm.CostCalculationGarment)
                .HasForeignKey(cm => cm.CostCalculationGarmentId)
                .IsRequired();
            //builder
            //    .HasOne(c => c.RO_Garment)
            //    .WithOne(ro => ro.CostCalculationGarment)
            //    .HasForeignKey<RO_Garment>(ro => ro.CostCalculationGarmentId)
            //    .IsRequired();
        }
    }
}
