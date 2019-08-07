using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Domain.Interfaces;
using Bankings.Data.Context;
using Bankings.Data.Repository;
using Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.Core.Bus;
using System;

namespace Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services )
        {
            ///Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services 
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
