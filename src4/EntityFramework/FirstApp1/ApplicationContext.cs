using Microsoft.EntityFrameworkCore;

namespace FirstApp1;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users => this.Set<User>();

	public ApplicationContext()
	{
		//this.Database.EnsureDeleted();
		//this.Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=D:\\projects\\DataBase\\helloapp1.db");
	}
}