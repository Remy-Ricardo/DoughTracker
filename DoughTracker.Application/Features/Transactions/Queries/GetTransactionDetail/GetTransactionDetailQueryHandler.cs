using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Transactions
{
    public class GetTransactionDetailQueryHandler : IRequestHandler<GetTransactionDetailQuery, TransactionDetailVm>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ITransactionCategoryRepository _transactionCategoryRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public GetTransactionDetailQueryHandler(IMapper mapper, ITransactionRepository transactionRepository,
            ITransactionCategoryRepository transactionCategoryRepository, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
            _transactionCategoryRepository = transactionCategoryRepository;
            _accountRepository = accountRepository;
        }

        public async Task<TransactionDetailVm> Handle(GetTransactionDetailQuery request, CancellationToken cancellationToken)
        {
            Transaction transaction = (await _transactionRepository.GetByIdAsync(request.TransactionID));
            TransactionDetailVm transactionDetailDto = _mapper.Map<TransactionDetailVm>(transaction);

            return transactionDetailDto;
        }
    }
}
