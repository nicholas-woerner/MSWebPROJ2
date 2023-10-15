using Microsoft.EntityFrameworkCore;
using MSWebPROJ2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProfileContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ProfileContext")));

var app = builder.Build();



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

