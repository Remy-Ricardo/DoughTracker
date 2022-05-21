using System;

namespace DoughTracker.Application.Features.Transactions
{
    public class TransactionDetailVm
    {
        public Guid TransactionID { get; set; }

        public Guid AccountID { get; set; }

        public Guid CategoryID { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string PaymentType { get; set; }

        public string TransactionType { get; set; }

        public string Status { get; set; }

        public DateTime Frequency { get; set; }

        public string Notes { get; set; }

        public DateTime Date { get; set; }
    }
}