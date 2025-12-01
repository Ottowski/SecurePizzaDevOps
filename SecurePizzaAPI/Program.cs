var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Listen to port 8080 in container.
builder.WebHost.UseUrls("http://0.0.0.0:80");
builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer(); // OpenAPI/Swagger support
builder.Services.AddSwaggerGen();           // Swagger generator

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SecurePizzaAPI V1");
    c.RoutePrefix = string.Empty; // Swagger to root 
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
