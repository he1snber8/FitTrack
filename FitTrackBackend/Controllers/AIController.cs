 [ApiController]
 [Route("api/[controller]")]
 public class AIController : ControllerBase {
     private readonly IAIService _aiService;
     public AIController(IAIService aiService) {
         _aiService = aiService;
     }
     [HttpPost("generate-workout")]
     public async Task<IActionResult> GenerateWorkout([FromBody] int userId) {
         // Retrieve user profile and generate plan
         var user = await _unitOfWork.UserProfiles.GetByIdAsync(userId);
         var plan = await _aiService.GenerateWorkoutPlanAsync(user);
         return Ok(plan);
     }
     [HttpPost("generate-nutrition")]
     public async Task<IActionResult> GenerateNutrition([FromBody] int userId) {
         var user = await _unitOfWork.UserProfiles.GetByIdAsync(userId);
         var plan = await _aiService.GenerateNutritionPlanAsync(user);
         return Ok(plan);
     }
 }