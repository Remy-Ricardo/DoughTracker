using System;

namespace DoughTracker.Application.Features.Transactions
{
    public class TransactionListVm
    {
        public Guid TransactionID { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

    }
}