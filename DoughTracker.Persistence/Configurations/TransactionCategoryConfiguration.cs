using DoughTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence.Configurations
{
    public class TransactionCategoryConfiguration : IEntityTypeConfiguration<TransactionCategory>
    {
        public void Configure(EntityTypeBuilder<TransactionCategory> builder)
        {
            builder.Property<Guid>(tc => tc.CategoryID)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.Property<string>(tc => tc.CategoryName)
                .IsRequired()
                .HasColumnType("varchar(20)") ;
        }
    }
}
