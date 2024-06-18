using Abstractions.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces
{
    public interface IRegistrationService
    {
        Task<CreateUserDTO> CreateUser(CreateUserDTO userDTO);
    }
}
