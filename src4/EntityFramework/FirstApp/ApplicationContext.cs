using Microsoft.EntityFrameworkCore;

namespace FirstApp;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users => this.Set<User>();

	public ApplicationContext()
	{
		/*this.Database.EnsureDeleted();
		this.Database.EnsureCreated();*/
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=helloapp.db");
	}
}