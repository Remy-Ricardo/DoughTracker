using AutoMapper;
using DoughTracker.Application.Contracts.Infrastructure;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Application.Models.Mail;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Accounts.Commands.AddAccount
{
    public class AddAccountCommandHandler : IRequestHandler<AddAccountCommand, AddAccountCommandResponse>
    {
        public readonly IAccountRepository _accountRepository;
        public readonly IEmailService _emailService;
        public readonly IMapper _mapper;

        public AddAccountCommandHandler(IAccountRepository accountRepository, IEmailService emailService, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        public async Task<AddAccountCommandResponse> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
            AddAccountCommandResponse addAccountCommandResponse = new AddAccountCommandResponse();
            AddAccountCommandValidator validator = new AddAccountCommandValidator();

            var validationResult = (await validator.ValidateAsync(request));

            if (validationResult.Errors.Any())
            {
                addAccountCommandResponse.Success = false;
                addAccountCommandResponse.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    addAccountCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (addAccountCommandResponse.Success)
            {
                Account account = new Account()
                {
                    AccountTypeID = request.AccountTypeID,
                    Balance = request.Balance,
                    Description = request.Description,
                    Active = request.Active,
                };

                account = (await _accountRepository.AddAsync(account));
                addAccountCommandResponse.Account = _mapper.Map<AddAccountDto>(account);
                //addAccountCommandResponse.Message = ServiceAssertion

                Email email = new Email();
                await _emailService.SendEmail(email);
            }

            return addAccountCommandResponse;
        }
    }
}
