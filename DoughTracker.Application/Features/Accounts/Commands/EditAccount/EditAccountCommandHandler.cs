using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Accounts.Commands.EditAccount
{
    public class EditAccountCommandHandler : IRequestHandler<EditAccountCommand>
    {
        public readonly IAccountRepository _accountRepository;
        public readonly IMapper _mapper;

        public EditAccountCommandHandler(IMapper mapper, IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EditAccountCommand request, CancellationToken cancellationToken)
        {
            Account accountToEdit = (await _accountRepository.GetByIdAsync(request.AccountID));

            _mapper.Map(request, accountToEdit, typeof(EditAccountCommand), typeof(Account));

            await _accountRepository.UpdateAsync(accountToEdit);

            return Unit.Value;
        }
    }
}
