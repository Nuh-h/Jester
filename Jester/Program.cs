using HealthChecks.UI.Client;
using Jester.DAL.NewsRepository;
using Jester.Data;
using Jester.Models;
using Jester.Services;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Jester.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var ConnectionsString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddHealthChecks();
    //.AddNpgSql(builder.Configuration.GetConnectionString("DefaultConnection")); //Disabling as it could keep DB awake, will require further work

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NewsContext>(options => options.UseNpgsql(ConnectionsString));
builder.Services.AddDbContext<IdentityContext>(options => options.UseNpgsql(ConnectionsString));
builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityContext>();

builder.Services.AddScoped<INewsRepository<NewsItem>, NewsRepository> ();
builder.Services.AddScoped<INewsService, NewsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection(); //TODO: needs re-enabling at the right time
app.UseStaticFiles();

app.UseRouting();

app.MapHealthChecks("/healthcheck", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
