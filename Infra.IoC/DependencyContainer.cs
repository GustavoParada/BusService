using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Domain.CommandHandlers;
using Banking.Domain.Commands;
using Banking.Domain.Interfaces;
using Bankings.Data.Context;
using Bankings.Data.Repository;
using Infra.Bus;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.Core.Bus;
using Project.Domain.Core.Entities;
using System;
using Transfer.Application.Interfaces;
using Transfer.Application.Services;
using Transfer.Data.Context;
using Transfer.Data.Repository;
using Transfer.Domain.EventHanlders;
using Transfer.Domain.Events;
using Transfer.Domain.Interfaces;

namespace Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            //var config = IConfiguration.GetSection("AppSettings").Get<AppSettings>();
            //services.AddTransient<AppSettings, config>();

            //Domain Baking Commands
            services.AddSingleton<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            ///Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>(sp => {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domains Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Application Services 
            services.AddTransient<IAccountService, AccountService>();

            //Transfer Services
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
