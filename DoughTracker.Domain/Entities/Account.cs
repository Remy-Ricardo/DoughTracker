using DoughTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Domain.Entities
{
    public class Account : AuditableEntity
    {
        public Guid AccountID { get; set; }

        public AccountTypes AccountType { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public decimal Balance { get; set; }

    }
}
