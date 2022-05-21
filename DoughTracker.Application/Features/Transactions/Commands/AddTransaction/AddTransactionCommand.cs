using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Transactions.Commands.AddTransaction
{
    public class AddTransactionCommand : IRequest<AddTransactionCommandResponse>
    {
        public Guid AccountID { get; set; }

        public string Description { get; set; }

        public Guid CategoryID { get; set; }

        public decimal Amount { get; set; }

        public string PaymentType { get; set; }

        public string TransactionType { get; set; }

        public string Status { get; set; }

        public string Frequency { get; set; }

        public string Notes { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Transaction Description: {Description}; Amount: {Amount}";
        }
    }
}
