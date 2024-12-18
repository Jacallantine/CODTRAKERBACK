using Microsoft.AspNetCore.Mvc;

using API.DATABASE;
using API.MODELS;
using API.SERVICE;


namespace API.CONTROLLERS
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login newLogin)
        {
            LoginService LoginInstance = new();
            var Account = await LoginInstance.AccountLogin(newLogin);
            return Ok(Account);
        }
    }
}