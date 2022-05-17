using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Transactions
{
    public class GetTransactionDetailQuery : IRequest<TransactionDetailVm>
    {
        public Guid TransactionID { get; set; }

    }
}
