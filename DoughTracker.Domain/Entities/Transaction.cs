using DoughTracker.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Domain.Entities
{
    public class Transaction : AuditableEntity
    {
        public Guid TransactionID { get; set; }
        
        public Guid AccountID { get; set; }

        public string Description { get; set; }

        public Guid CategoryID { get; set; }

        public decimal Amount { get; set; }

        public string PaymentType { get; set; }

        public string TransactionType { get; set; }

        public string Status { get; set; }

        public DateTime Frequency { get; set; }

        public string Notes { get; set; }

        public DateTime Date { get; set; }

    }
}
