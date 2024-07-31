using Microsoft.EntityFrameworkCore;
using NortwindDatabase.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Database:Connection"]);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
