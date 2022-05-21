using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Accounts.Commands.AddAccount
{
    public class AddAccountCommandValidator : AbstractValidator<AddAccountCommand>
    {
        public AddAccountCommandValidator()
        {
            RuleFor(x => x.AccountID).NotEmpty().NotNull();
            RuleFor(x => x.AccountTypeID).NotEmpty().NotNull();
            RuleFor(x => x.Active).NotEmpty().NotNull();
            RuleFor(x => x.Balance).NotEmpty().NotNull();
            RuleFor(x => x.Description).NotEmpty().NotNull();

        }
    }
}
