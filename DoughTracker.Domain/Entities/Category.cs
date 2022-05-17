using System;

namespace DoughTracker.Domain.Entities
{
    public class Category
    {
        public Guid CategoryID { get; set; }

        public string CategoryName { get; set; }

        public Subcategory Subcategory { get; set; }
    }
}