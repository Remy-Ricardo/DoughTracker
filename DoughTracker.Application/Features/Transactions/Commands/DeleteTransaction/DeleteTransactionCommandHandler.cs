using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Transactions.Commands.DeleteTransaction
{
    public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand>
    {
        private readonly IAsyncRepository<Transaction> _transactionRepository;

        public DeleteTransactionCommandHandler(IAsyncRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Unit> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            Transaction transactionToDelete = (await _transactionRepository.GetByIdAsync(request.TransactionID));

            await _transactionRepository.DeleteAsync(transactionToDelete);

            return Unit.Value;
        }
    }
}
