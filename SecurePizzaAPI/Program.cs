var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer(); // ✅ OpenAPI/Swagger support
builder.Services.AddSwaggerGen();           // ✅ Swagger generator

var app = builder.Build();
// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();        // genererar /swagger/v1/swagger.json
    app.UseSwaggerUI();      // Swagger UI på /swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
