using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Accounts.Commands.EditAccount
{
    public class EditAccountCommand : IRequest
    {
        public Guid AccountID { get; set; }

        public Guid AccountTypeID { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public decimal Balance { get; set; }
    }
}
