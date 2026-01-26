using Application.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contacts}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();