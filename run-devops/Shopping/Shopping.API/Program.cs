using Shopping.API.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Services
builder.Services.AddControllers();

// New OpenAPI document generator
builder.Services.AddOpenApi();

//// Swagger ecosystem (for UI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ProductContext>();


var app = builder.Build();

// 2. Middleware / pipeline
if (app.Environment.IsDevelopment())
{
    // OpenAPI JSON at /openapi/v1.json
    app.MapOpenApi();

    //// Swagger JSON + UI
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseSwaggerUI(c =>
    //{
    //    // Tell Swagger UI to read from the OpenAPI endpoint
    //    c.SwaggerEndpoint("/openapi/v1.json", "Shopping.API v1");

    //    // URL will be: /swagger
    //    c.RoutePrefix = "swagger";
    //});
}

app.UseAuthorization();

app.MapControllers();

app.Run();
