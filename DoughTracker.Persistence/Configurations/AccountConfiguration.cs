using DoughTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property<Guid>(a => a.AccountID)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.Property<string>(a => a.Description)
                .IsRequired()
                .HasColumnType("nvarchar(50)");


            builder.Property<long>(a => a.AccountNumber)
                .IsRequired()
                .HasColumnType("int"); ;

            builder.Property<long>(a => a.RoutingNumber)
                .HasColumnType("int");

            builder.Property<Guid>(a => a.AccountTypeID)
                .IsRequired()
                .HasColumnType("uniqueidentifier");

            builder.Property<bool>(a => a.Active)
                .IsRequired()
                .HasColumnType("boolean");

            builder.Property(a => a.Balance)
                .IsRequired()
                .HasColumnType("money");

            builder.Property<string>(a => a.CreatedBy)
                .HasColumnType("nvarchar(25)");

            builder.Property<DateTime>(a => a.CreatedDate)
                .HasColumnType("datetime2");

            builder.Property<string>(a => a.LastModifiedBy)
                .HasColumnType("nvarchar(25)");

            builder.Property<DateTime?>(a => a.LastModifiedDate)
                .HasColumnType("datetime2");

        }
    }
}
