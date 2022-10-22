using EfCore_Sample.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region Context

// This ConnectionString : 
var connectionString = builder.Configuration.GetConnectionString("LocalHostConnection");
// Or
var connectionString2 = builder.Configuration.GetSection("connectionString")["LocalHostConnection"];
// End ConnectionString

// --------------------

// This Add Context 

builder.Services.AddDbContext<EfCoreContext>(x => x.UseSqlServer(connectionString));

// End Add Context

#endregion


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
