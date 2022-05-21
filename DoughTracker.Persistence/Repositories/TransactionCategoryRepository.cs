using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoughTracker.Persistence.Repositories
{
    public class TransactionCategoryRepository : BaseRespository<TransactionCategory>, ITransactionCategoryRepository
    {
        public TransactionCategoryRepository(DoughTrackerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
