public class NutritionPlan {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Meals { get; set; }
    public string DietaryRestrictions { get; set; }
    public DateTime CreatedAt { get; set; }
}