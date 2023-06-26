using Microsoft.EntityFrameworkCore;
using MotorDeport.DataBase.Configs;

namespace MotorDeport.DataBase;

public class MotorDeportContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MotorDeport;Trusted_Connection=True;TrustServerCertificate=True;");
	}
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new CarConfiguration());
		modelBuilder.ApplyConfiguration(new DriverConfiguration());
	}
}