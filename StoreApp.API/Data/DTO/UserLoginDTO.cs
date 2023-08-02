﻿using System.ComponentModel.DataAnnotations;

namespace StoreApp.API.Data.DTO
{
    public class UserLoginDTO
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
