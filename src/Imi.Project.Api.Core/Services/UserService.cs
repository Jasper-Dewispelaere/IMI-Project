using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Models;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJwtService _jwtService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _baseAddress;

        public UserService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IJwtService jwtService,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
            _httpContextAccessor = httpContextAccessor;
            _baseAddress = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";
        }

        public async Task<AuthenticateResultModel> LoginAsync(LoginModel loginModel)
        {
            var login = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, true, false);
            if (login.Succeeded == false)
            {
                return new AuthenticateResultModel
                {
                    IsSuccess = false,
                    Messages = new List<string> { "Login failed!" }
                };
            }
            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            var claims = (List<Claim>)await _userManager.GetClaimsAsync(user);
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth.ToShortDateString()));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            var token = _jwtService.GenerateToken(claims);
            var serializedToken = _jwtService.SerializeToken(token);
            return new AuthenticateResultModel { IsSuccess = true, Token = serializedToken };
        }

        public async Task<AuthenticateResultModel> RegisterAsync(RegisterModel registerModel)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = registerModel.Email,
                Email = registerModel.Email,
                DateOfBirth = registerModel.DateOfBirth,
                HasApprovedTermsAndConditions = registerModel.HasApprovedTermsAndConditions
            };
            var result = await _userManager.CreateAsync(applicationUser, registerModel.Password);
            if (result.Succeeded == false)
            {
                return new AuthenticateResultModel
                {
                    Messages = new List<string> { "Registration failed!" }
                };
            }
            applicationUser = await _userManager.FindByEmailAsync(registerModel.Email);
            await _userManager.AddClaimAsync(applicationUser, new Claim("registration-date", DateTime.UtcNow.ToString("dd-MM-yyyy")));
            await _userManager.AddClaimAsync(applicationUser, new Claim(ClaimTypes.Role, "User"));

            await _userManager.UpdateAsync(applicationUser);

            return new AuthenticateResultModel
            {
                IsSuccess = true,
                Messages = new List<string> { "User registered!" }
            };
        }
    }
}
