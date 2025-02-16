using Microsoft.EntityFrameworkCore;
using ProfessorRating.DbContext;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<EmailService>(); -> CREATE EMAIL LATER ON!
// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddDbContext<ProfessorRatingDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.UseCors("AllowAll");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
    app.UseHsts();
}
app.UseWebSockets();  // ✅ Enable WebSockets

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
