using API.Dtos;
using API.Entities;
using API.Helpers;
using API.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using API.Services;
using API.Models.Accounts;
using System.Security.Cryptography;

namespace API.Services
{
    public class AccountService : IAccountService
    {
         private readonly AiManagerContext _aiManagerContext;
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IEmailService _emailService;
        private readonly UserManager<User> _userManager;

        public AccountService(AiManagerContext aiManagerContext, 
            IMapper mapper, IOptions<AppSettings> appSettings, 
            IEmailService emailService,UserManager<User> userManager)
        {
            _aiManagerContext = aiManagerContext;
            _mapper = mapper;
            _appSettings = appSettings;
            _emailService = emailService;
             _userManager = userManager;
        }

        public  void Register(RegisterDto registerDto, string origin)
        {


        }

        public void VerifyEmail(string token)
        {
            var user = _aiManagerContext.Users.SingleOrDefault(x => x.VerificationToken == token);
            if (user == null) throw new AppException("Verification failed");
            user.Verified = DateTime.UtcNow;
            user.VerificationToken = null;

            _aiManagerContext.Users.Update(user);
            _aiManagerContext.SaveChanges();
        }

        public void sendAlreadyRegisteredEmail(string email, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
                message = $@"<p>If you don't know your password please visit the <a href=""{origin}/user/forgot-password"">forgot password</a> page.</p>";
            else
                message = "<p>If you don't know your password you can reset it via the <code>/users/forgot-password</code> api route.</p>";

            _emailService.Send(
                to: email,
                subject: "Sign-up Verification API - Email Already Registered",
                html: $@"<h4>Email Already Registered</h4>
                         <p>Your email <strong>{email}</strong> is already registered.</p>
                         {message}"
            );
        }

        public void sendVerificationEmail(User user, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
            {
                var verifyUrl = $"{origin}/user/verify-email?token={user.VerificationToken}";
                message = $@"<p>Please click the below link to verify your email address:</p>
                             <p><a href=""{verifyUrl}"">{verifyUrl}</a></p>";
            }
            else
            {
                message = $@"<p>Please use the below token to verify your email address with the <code>/users/verify-email</code> api route:</p>
                             <p><code>{user.VerificationToken}</code></p>";
            }

            _emailService.Send(
                to: user.Email,
                subject: "Sign-up - Verify Email",
                html: $@"<h4>Verify Email</h4>
                         <p>Thanks for registering!</p>
                         {message}"
            );
        }

        public void ForgotPassword(ForgotPasswordRequest model, string origin)
        {
            var user = _aiManagerContext.Users.SingleOrDefault(x => x.Email == model.Email);

            // always return ok response to prevent email enumeration
            if (user == null) return;

            // create reset token that expires after 1 day
            user.ResetToken = randomTokenString();
            user.ResetTokenExpires = DateTime.UtcNow.AddDays(1);

            _aiManagerContext.Users.Update(user);
            _aiManagerContext.SaveChanges();

            // send email
            sendPasswordResetEmail(user, origin);
        }

        public void ValidateResetToken(ValidateResetTokenRequest model)
        {
            var user = _aiManagerContext.Users.SingleOrDefault(x =>
                x.ResetToken == model.Token &&
                x.ResetTokenExpires > DateTime.UtcNow);

            if (user == null)
                throw new AppException("Invalid token");
        }

        public void ResetPassword(ResetPasswordRequest model)
        {
            var user = _aiManagerContext.Users.SingleOrDefault(x => 
            x.ResetToken == model.Token && x.ResetTokenExpires > DateTime.UtcNow);

            if (user == null)
                throw new AppException("Invalid token");
            user.PasswordReset = DateTime.UtcNow;
            user.ResetToken = null;
            user.ResetTokenExpires = null;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

            _aiManagerContext.Users.Update(user);
            _aiManagerContext.SaveChanges();
        }

        private string randomTokenString()
        {
            //using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            var randomBytes = new byte[40];
            rng.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private void sendPasswordResetEmail(User user, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
            {
                var resetUrl = $"{origin}/account/reset-password?token={user.ResetToken}";
                message = $@"<p>Please click the below link to reset your password, the link will be valid for 1 day:</p>
                             <p><a href=""{resetUrl}"">{resetUrl}</a></p>";
            }
            else
            {
                message = $@"<p>Please use the below token to reset your password with the <code>/accounts/reset-password</code> api route:</p>
                             <p><code>{user.ResetToken}</code></p>";
            }

            _emailService.Send(
                to: user.Email,
                subject: "Sign-up Verification API - Reset Password",
                html: $@"<h4>Reset Password Email</h4>
                         {message}"
            );
        }

    }
}