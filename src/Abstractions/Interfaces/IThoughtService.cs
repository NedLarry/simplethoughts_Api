using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstractions.DTOs;
using Abstractions.Models;

namespace Abstractions.Interfaces
{
    public interface IThoughtService
    {
        Task<BaseResponse<Thought>> CreateThought (CreateThoughtDTO thought);
    }
}