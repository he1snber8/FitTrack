public class WorkoutPlan {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Exercises { get; set; }
    public string Schedule { get; set; }
    public DateTime CreatedAt { get; set; }
}