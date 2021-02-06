using MediatR;
using MyStore.Domain.Core.Bus;
using MyStore.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public Task SendCommand<T>(T command) where T: Command
        {
            return this._mediator.Send(command);
        }
    }
}
