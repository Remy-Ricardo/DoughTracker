using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IAsyncRepository<Transaction>
    {

    }
}
