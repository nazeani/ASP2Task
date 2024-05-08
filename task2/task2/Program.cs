using ASPTask2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options=>
    {
        options.UseSqlServer("Server=DESKTOP-2TU58SD\\SQLEXPRESS;Database=ASPTaskSecond;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;");
});
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();