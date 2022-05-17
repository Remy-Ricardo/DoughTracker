using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Application.Features.Transactions.Queries.GetTransactionList;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Transactions
{
    public class GetTransactionListQueryHandler : IRequestHandler<GetTransactionListQuery, List<TransactionListVm>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public GetTransactionListQueryHandler(IMapper mapper, ITransactionRepository transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        public async Task<List<TransactionListVm>> Handle(GetTransactionListQuery request, CancellationToken cancellationToken)
        {
            var allTransactions = (await _transactionRepository.ListAllAsync()).OrderBy(x => x.Date);

            List<TransactionListVm> transactionListVM = _mapper.Map<List<TransactionListVm>>(allTransactions);

            return transactionListVM;

            throw new NotImplementedException();
        }
    }
}
