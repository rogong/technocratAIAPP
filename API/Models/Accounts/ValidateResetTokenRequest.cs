using System.ComponentModel.DataAnnotations;

namespace API.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
