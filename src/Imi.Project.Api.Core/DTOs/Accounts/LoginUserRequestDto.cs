﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.DTOs.Accounts
{
    public class LoginUserRequestDto 
    { 
        public string Email { get; set; } 
        public string Password { get; set; } 
    }
}
