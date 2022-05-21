using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence.Repositories
{
    public class TransactionRepository : BaseRespository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(DoughTrackerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
