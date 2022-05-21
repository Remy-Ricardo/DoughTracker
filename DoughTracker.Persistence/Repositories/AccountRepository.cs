using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence.Repositories
{
    public class AccountRepository : BaseRespository<Account>, IAccountRepository
    {
        public AccountRepository(DoughTrackerDbContext dbContext) : base(dbContext)
        {

        }

    }
}
