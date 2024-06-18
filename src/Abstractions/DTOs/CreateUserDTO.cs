using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.DTOs
{
    public class CreateUserDTO
    {
        public string UserName { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
