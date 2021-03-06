﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FlightManager.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string PersonalNumber { get; set; }

        public string Address { get; set; }
    }
}
