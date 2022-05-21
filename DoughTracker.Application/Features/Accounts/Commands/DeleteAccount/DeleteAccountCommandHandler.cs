using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Accounts.Commands.DeleteAccount
{
    public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand>
    {
        public readonly IAccountRepository _accountRepository;

        public DeleteAccountCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }


        public async Task<Unit> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            Account accountToDelete = (await _accountRepository.GetByIdAsync(request.AccountID));

            await _accountRepository.DeleteAsync(accountToDelete);
            return Unit.Value;
        }
    }
}
