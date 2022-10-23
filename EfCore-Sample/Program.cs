using EfCore_Sample.Context;
using EfCore_Sample.Repositories.Repository;
using EfCore_Sample.Repositories.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region Context

// This ConnectionString : 
var connectionString = builder.Configuration.GetConnectionString("LocalHostConnection");
if (String.IsNullOrWhiteSpace(connectionString))
{
    // ConnectionString Is Null !!!
    connectionString = "ConnectionString Is Null !!!";
}
// Or
var connectionString2 = builder.Configuration.GetSection("connectionString")["LocalHostConnection"];
// End ConnectionString

// --------------------

// This Add Context 

builder.Services.AddDbContext<EfCoreContext>(x => x.UseSqlServer(connectionString));

// End Add Context

#endregion

#region IOC

builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();

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
