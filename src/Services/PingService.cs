using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PingService : IPingService
    {
        public PingService()
        {
            
        }
        public Task<string> Ping() => Task.FromResult("WE UP!!!");
    }
}
