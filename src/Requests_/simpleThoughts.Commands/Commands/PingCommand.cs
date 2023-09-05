using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests_.simpleThoughts.Commands.Commands
{
    public class PingCommand : IRequest<string>
    {
    }
}
