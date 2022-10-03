using Asp.net_Core.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//Configurar base de datos
builder.Services.AddDbContext<AplicationDbContext>(options=>options.UseSqlServer(

    //Pasar el connection string creado en appsettings
    builder.Configuration.GetConnectionString("DefaultConnection")
    
    ));

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

IApplicationBuilder applicationBuilder = app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
