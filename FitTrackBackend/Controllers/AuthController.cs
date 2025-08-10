 [ApiController]
 [Route("api/[controller]")]
 public class AuthController : ControllerBase {
     private readonly IUserService _userService;
     public AuthController(IUserService userService) {
         _userService = userService;
     }
     [HttpPost("register")]
     public async Task<IActionResult> Register([FromBody] RegisterDto dto) {
         var result = await _userService.RegisterAsync(dto);
         if (!result.Success) return BadRequest(result.Errors);
         return Ok(result);
     }
     [HttpPost("login")]
     public async Task<IActionResult> Login([FromBody] LoginDto dto) {
         var token = await _userService.LoginAsync(dto);
         if (string.IsNullOrEmpty(token)) return Unauthorized();
         return Ok(new { Token = token });
     }
 }