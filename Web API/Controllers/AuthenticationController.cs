using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Authenticate([FromHeader] string InfoToken)
        {
            var Token = new JwtSecurityTokenHandler();
            var JwtToken = Token.ReadJwtToken(InfoToken);
            var Email = "";
            var Password = "";

            foreach (var claim in JwtToken.Claims)
            {
                if (claim.Type == "email") Email = claim.Value;
                else if (claim.Type == "password") Password = claim.Value;
            }

            return Ok();
        }

        public IActionResult Register([FromHeader] string Email, [FromHeader] string PassHash, [FromHeader] string Name, [FromHeader] DateTime Dob)
        {
            
            return Ok();
        }
    }
}

