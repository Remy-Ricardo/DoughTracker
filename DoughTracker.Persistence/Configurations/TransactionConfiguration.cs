using DoughTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property<Guid>(t => t.TransactionID)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.Property<Guid>(t => t.AccountID)
                .IsRequired()
                .HasColumnType("uniqueidentifier"); ;
            
            builder.Property<Guid>(t => t.CategoryID)
                .IsRequired()
                .HasColumnType("uniqueidentifier"); ;
            
            builder.Property<DateTime>(t => t.Date)
                .IsRequired()
                .HasColumnType("datetime2");

            builder.Property<decimal>(t => t.Amount)
                .IsRequired()
                .HasColumnType("money"); ;

            builder.Property<string>(t => t.Description)
                .HasColumnType("nvarchar(50)");

            builder.Property<string>(t => t.Frequency)
               .HasColumnType("nvarchar(50)");

            builder.Property<string>(t => t.Notes)
                .HasColumnType("nvarchar(100)");

            builder.Property<string>(t => t.PaymentType)
                .HasColumnType("nvarchar(25)");

            builder.Property<string>(t => t.TransactionType)
                .HasColumnType("nvarchar(25)");

            builder.Property<string>(t => t.CreatedBy)
                .HasColumnType("nvarchar(25)");

            builder.Property<DateTime>(t => t.CreatedDate)
                .HasColumnType("datetime2");

            builder.Property<string>(t => t.LastModifiedBy)
                .HasColumnType("nvarchar(25)");

            builder.Property<DateTime?>(t => t.LastModifiedDate)
                .HasColumnType("datetime2");
        }
    }
}
