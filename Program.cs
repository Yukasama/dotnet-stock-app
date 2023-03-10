using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Obliviate.Data;
using Obliviate.Services.Stocks;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
string connectionString = "";
if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    connectionString = config.GetValue<string>("DefaultConnection");
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));
}
else
{
    string connectionPw = config.GetValue<string>("AzureSQL");
    connectionString = config.GetValue<string>("MacConnection");
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString + connectionPw));
}

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddAntiforgery();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 8;
});

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddScoped<StockManager>();
builder.Services.AddScoped<StockCalculator>();

builder.Services.AddAuthentication()
   .AddGoogle(options =>
   {
       IConfigurationSection googleAuthNSection =
       config.GetSection("Authentication:Google");
       options.ClientId = googleAuthNSection["ClientId"];
       options.ClientSecret = googleAuthNSection["ClientSecret"];
   })
   .AddFacebook(options =>
   {
       IConfigurationSection facebookAuthNSection =
       config.GetSection("Authentication:Facebook");
       options.AppId = facebookAuthNSection["AppId"];
       options.AppSecret = facebookAuthNSection["AppSecret"];
       options.AccessDeniedPath = "/AccessDeniedPathInfo";
   })
   .AddMicrosoftAccount(options =>
   {
       options.ClientId = config["Authentication:Microsoft:ClientId"];
       options.ClientSecret = config["Authentication:Microsoft:ClientSecret"];
   });


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
