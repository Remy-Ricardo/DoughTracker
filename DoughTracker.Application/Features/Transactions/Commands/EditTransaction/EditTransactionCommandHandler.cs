using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Transactions.Commands.EditTransaction
{
    public class EditTransactionCommandHandler : IRequestHandler<EditTransactionCommand>
    {
        private readonly IAsyncRepository<Transaction> _transactionRepository;
        private readonly IMapper _mapper;

        public EditTransactionCommandHandler(IMapper mapper, IAsyncRepository<Transaction> transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        public async Task<Unit> Handle(EditTransactionCommand request, CancellationToken cancellationToken)
        {
            var transactionToEdit = (await _transactionRepository.GetByIdAsync(request.TransactionID));

            _mapper.Map(request, transactionToEdit, typeof(EditTransactionCommand), typeof(Transaction));

            await _transactionRepository.UpdateAsync(transactionToEdit);

            return Unit.Value;
        }

    }
}
