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
        private readonly IAsyncRepository<Transaction> _transactionRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Account> _accountRepository;
        private readonly IMapper _mapper;

        public GetTransactionDetailQueryHandler(IMapper mapper, IAsyncRepository<Transaction> transactionRepository, 
            IAsyncRepository<Category> categoryRepository, IAsyncRepository<Account> accountRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _accountRepository = accountRepository;
        }

        public async Task<TransactionDetailVm> Handle(GetTransactionDetailQuery request, CancellationToken cancellationToken)
        {
            Transaction @transaction = (await _transactionRepository.GetByIdAsync(request.TransactionID));
            TransactionDetailVm transactionDetailDto = _mapper.Map<TransactionDetailVm>(@transaction);

            Category category = (await _categoryRepository.GetByIdAsync(transaction.CategoryID));
            Account account = (await _accountRepository.GetByIdAsync(transaction.AccountID));
            transactionDetailDto.Category = _mapper.Map<CategoryDto>(category);
            transactionDetailDto.Account = _mapper.Map<AccountDto>(account);

            return transactionDetailDto;
        }
    }
}
