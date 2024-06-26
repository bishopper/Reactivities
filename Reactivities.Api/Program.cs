using Microsoft.EntityFrameworkCore;
using Reactivities.Infra.Data.Context;
using Reactivities.Infra.IOC.DependencyContainer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Config Database

builder.Services.AddDbContext<ReactivitiesDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReactivitiesConnectionString"));
});

#endregion

builder.Services.AddCors(option =>
{
    option.AddPolicy("ReactivitiesPolicy", policy =>
    {
        policy.AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:5173/");
    });
});

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("ReactivitiesPolicy");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
