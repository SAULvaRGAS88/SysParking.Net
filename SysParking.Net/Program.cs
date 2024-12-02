using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SysParking.Net.Areas.Identity.Data;
using SysParking.Net.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SysParkingNetContextConnection") ?? throw new InvalidOperationException("Connection string 'SysParkingNetContextConnection' not found.");

builder.Services.AddDbContext<SysParkingNetContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<UsuarioModel>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<SysParkingNetContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");
app.MapRazorPages();
app.Run();
