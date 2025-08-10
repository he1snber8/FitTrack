public class AppDbContext : DbContext {
    public DbSet<UserProfile> Users { get; set; }
    public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
    public DbSet<NutritionPlan> NutritionPlans { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}