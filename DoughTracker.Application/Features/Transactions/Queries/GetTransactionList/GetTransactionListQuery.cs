using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Transactions.Queries.GetTransactionList
{
    public class GetTransactionListQuery : IRequest<List<TransactionListVm>>
    {
    }
}
