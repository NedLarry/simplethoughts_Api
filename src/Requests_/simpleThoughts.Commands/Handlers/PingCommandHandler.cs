using Abstractions.Interfaces;
using MediatR;
using Requests_.simpleThoughts.Commands.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests_.simpleThoughts.Commands.Handlers
{
    public class PingCommandHandler : IRequestHandler<PingCommand, string>
    {

        private readonly IPingService _pingService;
        public PingCommandHandler(IPingService _pingService)
        {
            this._pingService = _pingService;
        }

        public async Task<string> Handle(PingCommand request, CancellationToken cancellationToken) => await _pingService.Ping();
    }
}
