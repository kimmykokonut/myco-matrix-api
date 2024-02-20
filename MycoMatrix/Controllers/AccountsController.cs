using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MycoMatrix.Models;

namespace MycoMatrix.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;
  private readonly IConfiguration _configuration;

  public AccountsController(UserManager<ApplicationUser> userManager,
  SignInManager<ApplicationUser> signInManager,
  IConfiguration configuration)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _configuration = configuration;
  }

  [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto user)
    {
      ApplicationUser userExists = await _userManager.FindByEmailAsync(user.Email);
      if (userExists != null)
      { 
        return BadRequest(new { status = "error", message = "Email already exists" });
      }
      ApplicationUser newUser = new() { Email = user.Email, UserName = user.UserName };
      IdentityResult result = await _userManager.CreateAsync(newUser, user.Password);
      if (result.Succeeded)
      {
        return Ok(new { status = "success", message = "User has been successfully created" });
      }
      else
      {
        return BadRequest(result.Errors);
      }
    }

  private string CreateToken(List<Claim> authClaims)
  {
    SymmetricSecurityKey authSigningKey = new(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

    JwtSecurityToken token = new(
      issuer: _configuration["JWT:ValidIssuer"],
      audience: _configuration["JWT:ValidAudience"],
      expires: DateTime.Now.AddHours(3),
      claims: authClaims,
      signingCredentials: new SigningCredentials(
        authSigningKey,
        SecurityAlgorithms.HmacSha256)
    );

    return new JwtSecurityTokenHandler().WriteToken(token);
  }

  [HttpPost("SignIn")]
  public async Task<IActionResult> SignIn(SignInDto userInfo)
  {
    ApplicationUser user = await _userManager.FindByEmailAsync(userInfo.Email);
    if (user != null)
    {
      var signInResult = await _signInManager.PasswordSignInAsync(user, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
      if (signInResult.Succeeded)
      {
        List<Claim> authClaims = new()
        {
          new Claim("UserId", user.Id)
        };
        string newToken = CreateToken(authClaims);
        return Ok(new { status = "success", message = $"{userInfo.Email} signed in", token = newToken });
      }
    }
    return BadRequest(new { status = "error", message = "Unable to sign in" });
  }
}
