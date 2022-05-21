using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoughTracker.Application.Contracts.Persistence
{
    public interface ITransactionCategoryRepository : IAsyncRepository<TransactionCategory>
    {

    }
}
