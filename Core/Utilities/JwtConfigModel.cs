﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class JwtConfigModel
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int AuthTokenLifetimeInMinutes { get; set; }
        public int RefreshTokenLifetimeInDays { get; set; }

        public SymmetricSecurityKey? Key { get; set; }
    }
}
