var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Register application services
builder.Services.AddScoped<IWorkoutPlanService, WorkoutPlanService>();
// Add other services like nutrition, AI modules
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});
app.Run();