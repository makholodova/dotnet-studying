using Microsoft.EntityFrameworkCore;

namespace FirstApp4;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=D:\\projects\\DataBase\\helloapp4.db");
	}
}