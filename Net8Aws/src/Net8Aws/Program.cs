var builder = WebApplication.CreateBuilder(args);

// Swagger + OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "AWS .NET 8 CI/CD Running Successfully!");

app.Run();
