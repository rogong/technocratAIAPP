using API.Dtos;
using API.Entities;
using API.Models.Accounts;

namespace API.Interface
{
    public interface IAccountService
    {
        //AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        //AuthenticateResponse RefreshToken(string token, string ipAddress);
        //void RevokeToken(string token, string ipAddress);
        void Register(RegisterDto model, string origin);
        void VerifyEmail(string token);
        //void VerifyPassword(string token);
        void sendAlreadyRegisteredEmail(string email, string origin);
        void sendVerificationEmail(User user, string origin);
        void ForgotPassword(ForgotPasswordRequest model, string origin);
        void ValidateResetToken(ValidateResetTokenRequest model);
        void ResetPassword(ResetPasswordRequest model);
        // IEnumerable<AccountResponse> GetAll();
        //AccountResponse GetById(int id);
        //AccountResponse Create(CreateRequest model);
        //AccountResponse Update(int id, UpdateRequest model);
        // void Delete(int id);
    }
}