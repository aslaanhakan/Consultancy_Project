using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Business.Concrate;
using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Data.Concrate.EfCore;
using Consultancy_Project.Data.Concrate.EfCore.Context;
using Consultancy_Project.Entity.Concrate.Identity;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ConsultancyProjectContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<ConsultancyProjectContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IConsultantService, ConsultantManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ISpecializationService, SpecializationManager>();

builder.Services.AddScoped<ISpecializationRepository, EfCoreSpecializationRepository>();
builder.Services.AddScoped<ICustomerRepository, EfCoreCustomerRepository>();
builder.Services.AddScoped<IConsultantRepository, EfCoreConsultantRepository>();
builder.Services.AddScoped<IImageRepository, EfCoreImageRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
