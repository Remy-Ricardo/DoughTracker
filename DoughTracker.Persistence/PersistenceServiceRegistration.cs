using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DoughTrackerDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DoughTrackerConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRespository<>));

            
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ITransactionCategoryRepository, TransactionCategoryRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            return services;
        }
    }
}
