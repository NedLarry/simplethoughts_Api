﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.DTOs
{
    public class LoginUserDTO
    {
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
