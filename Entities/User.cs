﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PorcXarxaAPI.Entities
{
    public class User : IdentityUser
    {
        public required string Name { get; set; }
        public required string Lastname { get; set; }
        public required string Role { get; set; }
    }
}
