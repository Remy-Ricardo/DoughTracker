using DoughTracker.Application.Responses;
using DoughTracker.Domain.Entities;
using System.Collections.Generic;

namespace DoughTracker.Application.Features.Transactions.Commands.AddTransaction
{
    public class AddTransactionCommandResponse : BaseResponse
    {
        public AddTransactionCommandResponse() : base()
        {

        }

        public AddTransactionDto Transaction { get; set; }
    }
}