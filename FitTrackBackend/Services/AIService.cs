public interface IAIService {
    Task<WorkoutPlan> GenerateWorkoutPlanAsync(UserProfile user);
    Task<NutritionPlan> GenerateNutritionPlanAsync(UserProfile user);
}

public class AIService : IAIService {
    public async Task<WorkoutPlan> GenerateWorkoutPlanAsync(UserProfile user) {
        // Integrate AI logic or call external ML models
        return new WorkoutPlan { /* populate with generated data */ };
    }
    public async Task<NutritionPlan> GenerateNutritionPlanAsync(UserProfile user) {
        // Integrate AI logic
        return new NutritionPlan { /* populate with generated data */ };
    }
}