using Microsoft.EntityFrameworkCore;
using MotorDeport.DataBase;
using MotorDeport.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DIMA: Register our custom services in dependency injection (DI)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MotorDeportContext>(options =>
	options
		.UseLazyLoadingProxies()
		.UseSqlServer(connectionString));

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

using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<MotorDeportContext>())
{
	context.Database.Migrate();
	//context.Database.EnsureDeleted();
	//context.Database.EnsureCreated();
}

app.Run();