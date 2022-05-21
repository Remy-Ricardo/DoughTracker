using System;
using System.ComponentModel.DataAnnotations;

namespace DoughTracker.Domain.Entities
{
    public class TransactionCategory
    {
        [Key]
        public Guid CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int SubcategoryID { get; set; }
    }
}