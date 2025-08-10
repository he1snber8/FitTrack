 [ApiController]
 [Route("api/[controller]")]
 public class UserProfilesController : ControllerBase {
     private readonly IUnitOfWork _unitOfWork;
     public UserProfilesController(IUnitOfWork unitOfWork) {
         _unitOfWork = unitOfWork;
     }
     [HttpGet]
     public async Task<IActionResult> GetUsers() {
         var users = await _unitOfWork.UserProfiles.GetAllAsync();
         return Ok(users);
     }
     [HttpPost]
     public async Task<IActionResult> CreateUser([FromBody] UserProfile user) {
         await _unitOfWork.UserProfiles.AddAsync(user);
         await _unitOfWork.CompleteAsync();
         return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
     }
 }