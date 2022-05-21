using DoughTracker.Domain.Common;
using DoughTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Persistence
{
    public class DoughTrackerDbContext : DbContext
    {
        

        public DoughTrackerDbContext(DbContextOptions<DoughTrackerDbContext> dbContextOptions) : base(dbContextOptions) { }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<TransactionCategory> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoughTrackerDbContext).Assembly);

            // seed data, added through migrations
            var checkingsAccountGuid = Guid.NewGuid();
            var savingsAccountGuid = Guid.NewGuid();
            var checkingsAccountTypeGuid = Guid.NewGuid();
            var savingsAccountTypeGuid = Guid.NewGuid();
            var housingCategoryGuid = Guid.NewGuid();
            var utiltiesCategoryGuid = Guid.NewGuid();


            #region Housing TransactionCategory
            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = housingCategoryGuid,
                CategoryName = "Housing",
                SubcategoryID = 1
            });


            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Housing",
                SubcategoryID = 2
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Housing",
                SubcategoryID = 3
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Housing",
                SubcategoryID = 4
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Housing",
                SubcategoryID = 5
            });

            #endregion Housing TransactionCategory

            #region Transportation TransactionCategory
            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 10
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 11
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 12
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 13
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 14
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 15
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 16
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Transportation",
                SubcategoryID = 17
            });

            #endregion Transportation TransactionCategory

            #region Food TransactionCategory
            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Food",
                SubcategoryID = 21
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Food",
                SubcategoryID = 22
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Food",
                SubcategoryID = 23
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Food",
                SubcategoryID = 24
            });

 #endregion Food TransactionCategory

            #region Utilities TransactionCategory

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 31
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = utiltiesCategoryGuid,
                CategoryName = "Utilities",
                SubcategoryID = 32
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 33
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 34
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 35
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 35
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 36
            });

            modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = "Utilities",
                SubcategoryID = 38
            });

            #endregion Utilities TransactionCategory
            /* modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Clothing"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Medical/Healthcare"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Insurance"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Household Items/Supplies"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Personal"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Debt"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Education"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Savings"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Gifts/Donations"
             });

             modelBuilder.Entity<TransactionCategory>().HasData(new TransactionCategory
             {
                 CategoryID = Guid.NewGuid(),
                 CategoryName = "Entertainment"
             });*/

            #region Housing Subcategories

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 1,
                SubcategoryName = "Mortgage"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 2,
                SubcategoryName = "Rent"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 3,
                SubcategoryName = "Property Taxes"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 4,
                SubcategoryName = "Household Repairs"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 5,
                SubcategoryName = "HOA Fees"
            });
            #endregion Housing Subcategories

            #region Transportation Subcategories
            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 10,
                SubcategoryName = "Car Payment"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 11,
                SubcategoryName = "Car Warranty"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 12,
                SubcategoryName = "Gas"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 13,
                SubcategoryName = "Tires"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 14,
                SubcategoryName = "Parking Fees"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 15,
                SubcategoryName = "Repairs"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 16,
                SubcategoryName = "Registration/DMV Fee"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 17,
                SubcategoryName = "Maintenance/Oil changes"
            });

            #endregion Transportation Subcategories

            #region Food Subcategories

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 21,
                SubcategoryName = "Groceries"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 22,
                SubcategoryName = "Restaurants"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 23,
                SubcategoryName = "Fast Food/Snacks"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 24,
                SubcategoryName = "Pet Food"
            });

            #endregion Food Subcategories

            #region Utilities Subcategories

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 31,
                SubcategoryName = "Electricity"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 32,
                SubcategoryName = "Gas"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 33,
                SubcategoryName = "Water"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 34,
                SubcategoryName = "Garbage"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 35,
                SubcategoryName = "Sewage"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 36,
                SubcategoryName = "Phones"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 37,
                SubcategoryName = "Cable"
            });

            modelBuilder.Entity<TransactionSubcategory>().HasData(new TransactionSubcategory
            {
                SubcategoryID = 38,
                SubcategoryName = "Internet"
            });

            #endregion Utilities Subcategories


            modelBuilder.Entity<Account>().HasData(new Account
            {
                AccountID = checkingsAccountGuid,
                AccountTypeID = checkingsAccountTypeGuid,
                AccountNumber = 1287518947,
                RoutingNumber = 031100649,
                Active = true,
                Balance = 1267.12m,
                Description = "Discover Checkings Account x2135"
            });

            modelBuilder.Entity<Account>().HasData(new Account
            {
                AccountID = savingsAccountGuid,
                AccountTypeID = savingsAccountTypeGuid,
                AccountNumber = 98723718947,
                RoutingNumber = 031100649,
                Active = true,
                Balance = 5812.64m,
                Description = "Discover Savings Account x2786",
            });

            modelBuilder.Entity<Transaction>().HasData(new Transaction
            {
                TransactionID = Guid.NewGuid(),
                AccountID = checkingsAccountGuid,
                CategoryID = housingCategoryGuid,
                Amount = 1152.64m,
                Date = new DateTime(2022, 05, 01),
                Frequency = "Every 1st of the month",
                Description = "Monthly Mortage Payment",
                PaymentType = "Checkings Transfer",
                Status = "Posted",
                TransactionType = "Expense",
                Notes = "",
            });

            modelBuilder.Entity<Transaction>().HasData(new Transaction
            {
                TransactionID = Guid.NewGuid(),
                AccountID = checkingsAccountGuid,
                Amount = 132.49m,
                CategoryID = utiltiesCategoryGuid,
                Date = new DateTime(2022, 05, 01),
                Frequency = "Every 25th of the month",
                Description = "Oklahoma Natural Gas Bill",
                PaymentType = "Checkings Transfer",
                Status = "Posted",
                TransactionType = "Expense",
                Notes = "",
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
