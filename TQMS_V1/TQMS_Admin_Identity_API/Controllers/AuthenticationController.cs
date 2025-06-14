
namespace TQMS_Admin_Identity_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationServices _service;

        public AuthenticationController(IAuthenticationServices service)
        {
            _service = service;
        }
        [HttpPost("Register")]

        public async Task<IActionResult> Register([FromBody] RegisterUser registerUser, [FromQuery] string role)
        {
            var result = await _service.RegisterUser(registerUser, role);
            if (result.StartsWith("User created successfully"))
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
