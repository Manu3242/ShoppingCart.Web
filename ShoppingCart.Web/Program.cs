using Microsoft.EntityFrameworkCore;
using ShoppingCart.Web.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//var conString = builder.Configuration.GetSection("MySettings:MyCartConnection");
builder.Services.AddDbContext<CartDBContext>(options => options.UseSqlServer
               (builder.Configuration.GetConnectionString("CartConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
