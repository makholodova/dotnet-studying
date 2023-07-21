using Microsoft.EntityFrameworkCore;
using MotorDeport.DataBase;
using MotorDeport.DataBase.Configs;
using MotorDeport.Services;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<MotorDeportContext>(options =>
//	options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MotorDeport;Trusted_Connection=True;TrustServerCertificate=True;"));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ICarService, CarService>();
builder.Services.AddTransient<IDriverService, DriverService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ITripService, TripService>();

////---------------------------------------------------------
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

app.MapControllerRoute(
	"default",
	"{controller=Trip}/{action=Index}/{id?}");

using (var context = new MotorDeportContext())
{
	//context.Database.EnsureDeleted();
	//context.Database.EnsureCreated();
}


app.Run();