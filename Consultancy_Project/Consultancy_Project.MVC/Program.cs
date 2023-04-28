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


builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;//�ifre i�inde mutlaka rakam olmal�
    options.Password.RequireLowercase = true;//�ifre i�inde mutlaka k���k harf olmal�
    options.Password.RequireUppercase = true;//�ifre i�inde mutlaka b�y�k harf olmal�
    options.Password.RequiredLength = 6; //Uzunlu�u 6 karakter olmal�
    options.Password.RequireNonAlphanumeric = true;//Alfan�meric olmayan karakter bar�nd�rmal�
    //�rnek ge�erli parola: Qwe123.

    options.Lockout.MaxFailedAccessAttempts = 3;//�st �ste izin verilecek hatal� giri� say�s� 3
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//Kilitlenmi� hesaba 5 dakika sonra giri� yap�labilsin

    options.User.RequireUniqueEmail = true;//Sistemde daha �nce kay�tl� olmayan bir email adresi ile kay�t olunabilsin
    options.SignIn.RequireConfirmedEmail = false;//Email onay� pasif 
    options.SignIn.RequireConfirmedPhoneNumber = false;//Telefon numaras� onay� pasif
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//E�er kullan�c� eri�ebilmesi i�in login olmak zorunda oldu�u bir yere istekte bulunursa, bu sayfaya y�nlendirilecek. (account controlleri i�indeki login action�)
    options.LogoutPath = "/account/logout";//Kullan�c� logout oldu�unda bu actiona y�nlendirilecek.
    options.AccessDeniedPath = "/account/accessdenied";//Kullan�c� yetkisi olmayan bir sayfaya istekte bulundu�unda bu actiona y�nlendirilecek.
    options.SlidingExpiration = true;//Cookie ya�am s�resinin her istekte s�f�rlanmas�n� sa�lar. Default olarak ya�am s�resi 20 dk, ama biz bunu ayarlayabiliriz.
    options.ExpireTimeSpan = TimeSpan.FromDays(10);//Ya�am s�resi 10 g�n olacak.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        Name = ".Consultancy.Security.Cookie"
    };
});
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IConsultantService, ConsultantManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ISpecializationService, SpecializationManager>();
builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<ICertificateService, CertificateManager>();

builder.Services.AddScoped<IEducationRepository, EFCoreEducationRepository>();
builder.Services.AddScoped<ICertificateRepository, EFCoreCertificateRepository>();
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
