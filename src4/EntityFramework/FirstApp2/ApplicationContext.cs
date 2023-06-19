using Microsoft.EntityFrameworkCore;

namespace FirstApp2;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
	}
}