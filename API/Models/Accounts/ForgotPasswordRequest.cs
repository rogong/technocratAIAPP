﻿using System.ComponentModel.DataAnnotations;

namespace API.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
