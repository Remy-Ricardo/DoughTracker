using DoughTracker.Application.Contracts.Infrastructure;
using DoughTracker.Application.Models.Mail;
using DoughTracker.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Infrastructure
{
    public static class InfrastructureServiceRegistraction
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
