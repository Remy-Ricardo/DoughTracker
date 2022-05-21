using System;
using System.ComponentModel.DataAnnotations;

namespace DoughTracker.Domain.Entities
{
    public class TransactionSubcategory
    {
        [Key]
        public int SubcategoryID { get; set; }

        public string SubcategoryName { get; set; }
    }
}