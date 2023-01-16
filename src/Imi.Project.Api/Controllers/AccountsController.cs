using Imi.Project.Api.Core.DTOs.Accounts;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Models;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserRequestDto registrationDto)
        {
            var registerModel = new RegisterModel
            {
                Email = registrationDto.Email,
                DateOfBirth = registrationDto.DateOfBirth,
                Password = registrationDto.Password
            };

            var result = await _userService.RegisterAsync(registerModel);

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Messages);
            }

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserRequestDto loginDto)
        {
            var loginModel = new LoginModel
            {
                Email = loginDto.Email,
                Password = loginDto.Password
            };

            var result = await _userService.LoginAsync(loginModel);

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Messages);
            }

            return Ok(new TokenDto { BearerToken = result.Token });

            //var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, lockoutOnFailure: false);
            //if (!result.Succeeded)
            //{
            //    return Unauthorized();
            //}
            //var applicationUser = await _userManager.FindByEmailAsync(login.Email);
            //JwtSecurityToken token = await GenerateTokenAsync(applicationUser); 
            //string serializedToken = new JwtSecurityTokenHandler().WriteToken(token); 
            //return Ok(new LoginUserResponseDto()
            //{
            //    Token = serializedToken
            //});
        }

        //private async Task<JwtSecurityToken> GenerateTokenAsync(ApplicationUser user)
        //{
        //    var claims = new List<Claim>(); 
        //    var userClaims = await _userManager.GetClaimsAsync(user);

        //    claims.AddRange(userClaims);

        //    var roleClaims = await _userManager.GetRolesAsync(user); 
        //    foreach (var roleClaim in roleClaims) 
        //    { 
        //        claims.Add(new Claim(ClaimTypes.Role, roleClaim)); 
        //    }

        //    var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays"); 
        //    var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey")); 
        //    var token = new JwtSecurityToken
        //    (
        //        issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"), 
        //        audience: _configuration.GetValue<string>("JWTConfiguration:Audience"), 
        //        claims: claims, 
        //        expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)), 
        //        notBefore: DateTime.UtcNow, 
        //        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey), SecurityAlgorithms.HmacSha256)
        //    );
        //    return token;
        //}
    }
}
