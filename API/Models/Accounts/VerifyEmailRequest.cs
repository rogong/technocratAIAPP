using System.ComponentModel.DataAnnotations;

namespace API.Models.Accounts
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }   
    }
}
