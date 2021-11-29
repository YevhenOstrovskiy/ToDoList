using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using System.Configuration;
using ToDoList.Data.Repository;
using Microsoft.AspNetCore.Components.Authorization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    builder.Services.AddDbContextPool<DB>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
    });
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IRepository, SQLRepository>();
builder.Services.AddScoped<ICalendarRepository, SQLCalendarRepository>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();



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

