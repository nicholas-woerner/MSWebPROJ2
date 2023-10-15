using Microsoft.EntityFrameworkCore;
using MSWebPROJ2.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddJsonFile("appsettings.json");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<ProfileContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();
app.Run();
