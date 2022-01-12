using API.Dtos;
using API.Entities;
using API.Helpers;
using API.Interface;
using API.Models.Accounts;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace API.Controllers
{
    // [Route("[controller]")]
    public class AccountController : BaseApiController
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly IAccountService _accountService;


    
        public AccountController(UserManager<User> userManager, 
        
        TokenService tokenService,
            IEmailService emailService, IAccountService accountService,  IMapper mapper)
        {
            
            _tokenService = tokenService;
            _userManager = userManager;
            _mapper = mapper;
            _emailService = emailService;
            _accountService = accountService;
            
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);

            if (!user.IsVerified || user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return Unauthorized();

            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDto registerDto, string origin)
        {
            
            //validate
            if (_userManager.Users.Any(x => x.Email == registerDto.Email))
            {
                //send alreday registered error in email to prevent account enumeration
                _accountService.sendAlreadyRegisteredEmail(registerDto.Email, origin);
             
                return StatusCode(404);
            }

            var  user = new User { 
                  UserName = registerDto.Username,
                  Email = registerDto.Email,
                  Created = DateTime.UtcNow,
                  VerificationToken =  randomTokenString()

                   };
            var result = await _userManager.CreateAsync(user, registerDto.Password);


            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return ValidationProblem();
            }

      

            await _userManager.AddToRoleAsync(user, "Member");

            // send email
            try
            {
                _accountService.sendVerificationEmail(user, origin);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }



            return Ok(new { message = "Registration successful, please check your email for verification instructions" });
        }

        [HttpPost("verify-email")]
        public IActionResult VerifyEmail(VerifyEmailRequest model)
        {
            _accountService.VerifyEmail(model.Token);
            return Ok(new { message = "Verification successful, you can now login" });
        }


        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }

        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword(ForgotPasswordRequest model)
        {
           // var WebUrl = $"{this.Request.Scheme}://{this.Request.Host}";
            _accountService.ForgotPassword(model, Request.Headers["origin"]);
            return Ok(new { message = "Please check your email for password reset instructions" });
        }

        [HttpPost("validate-reset-token")]
        public IActionResult ValidateResetToken(ValidateResetTokenRequest model)
        {
            _accountService.ValidateResetToken(model);
            return Ok(new { message = "Token is valid" });
        }

        [HttpPost("reset-password")]
        public IActionResult ResetPassword(ResetPasswordRequest model)
        {
            _accountService.ResetPassword(model);
            return Ok(new { message = "Password reset successful, you can now login" });
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

    }
}