using Abstractions.Interfaces;
using MediatR;
using Requests_.simpleThoughts.Queries.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests_.simpleThoughts.Queries.Handlers
{
    public class PingQueryHandler : IRequestHandler<PingQuery, string>
    {
        private readonly IPingService _pingService;

        public PingQueryHandler(IPingService _pingService)
        {
            this._pingService = _pingService;
        }
        public async Task<string> Handle(PingQuery request, CancellationToken cancellationToken) => await _pingService.Ping();
    }
}
