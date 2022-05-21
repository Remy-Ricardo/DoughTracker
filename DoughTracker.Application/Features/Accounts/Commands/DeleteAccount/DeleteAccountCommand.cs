using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Accounts.Commands.DeleteAccount
{
    public class DeleteAccountCommand : IRequest
    {
        public Guid AccountID { get; set; }
    }
}
