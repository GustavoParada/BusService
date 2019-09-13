using Banking.Domain.Commands;
using MediatR;
using Project.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace Banking.Domain.EventHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publicando evento no RabbitMQ
            return Task.FromResult(true);
        }
    }
}
