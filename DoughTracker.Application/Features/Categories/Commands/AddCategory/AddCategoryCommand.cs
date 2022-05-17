using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Categories.Commands
{
    public class AddCategoryCommand : IRequest<Guid>
    {
        public string CategoryName { get; set; }

    }
}
