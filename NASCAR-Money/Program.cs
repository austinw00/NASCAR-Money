using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using NASCAR_Money.Data.NascarCache;
using NASCAR_Money.DbModels;
using NASCAR_Money.Helpers;
using NASCAR_Money.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddHttpClient<CacheService>();
builder.Services.AddScoped<IEventIdHelper, EventIdHelper>();
builder.Services.AddScoped<IDriversHelper, DriversHelper>();
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<ITrackService, TrackService>();
builder.Services.AddDbContext<NascarMoneyDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddMudServices();
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


