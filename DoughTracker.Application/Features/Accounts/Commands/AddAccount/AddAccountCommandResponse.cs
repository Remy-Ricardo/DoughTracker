using DoughTracker.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Accounts.Commands.AddAccount
{
    public class AddAccountCommandResponse : BaseResponse
    {
        public AddAccountCommandResponse() : base()
        {

        }

        public AddAccountDto Account { get; set; }
    }
}
