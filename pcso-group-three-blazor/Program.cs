using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using pcso_group_three_blazor.Data;
using pcso_group_three_blazor.DBContext;
using pcso_group_three_blazor.IRepository;
using pcso_group_three_blazor.Model;
using pcso_group_three_blazor.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// get the connection string from the appsettings.json
//builder.Services.AddDbContext<ContextDB>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("GROUP3")));
builder.Services.AddDbContext<MobileOrganizationsContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("GROUP3")));

builder.Services.AddScoped<IMobileOrganizationsRepository, MobileOrganizationsRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
