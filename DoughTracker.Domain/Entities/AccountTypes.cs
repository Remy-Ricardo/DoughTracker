using System;
using System.ComponentModel.DataAnnotations;

namespace DoughTracker.Domain.Entities
{
    public class AccountTypes
    {
        [Key]
        public Guid AccountTypeID { get; set; }

        public string AccountType { get; set; }
    }
}