var builder = WebApplication.CreateBuilder(args);
// Add MVC services
builder.Services.AddControllersWithViews();
var app = builder.Build();
// Enable static files from wwwroot
app.UseStaticFiles();
// Enable routing
app.UseRouting();
// Configure MVC routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();