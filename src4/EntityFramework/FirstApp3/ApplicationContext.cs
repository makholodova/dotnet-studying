using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstApp3;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	public ApplicationContext()
	{
		this.Database.EnsureDeleted();
		this.Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=D:\\projects\\DataBase\\helloapp3.db");
	}
	//включения сущности в модель
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		var builder = modelBuilder.Entity<Country>();
		
		builder.ToTable("Country").HasKey(p => p.Id);
		builder.Property(p => p.Name).IsRequired().HasMaxLength(30).HasColumnName("asd");
		builder.Property(p => p.Id).IsRequired();
		
		
			
		modelBuilder.ApplyConfiguration(new ProductConfiguration());
	}
	
	public class ProductConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.ToTable("Country").HasKey(p => p.Id);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
		}
	}
	
	//исключить сущность из модели (методом)
	/*protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Ignore<Company>();
	}*/
	//исключить определенное свойство, чтобы для него не создавался столбец в таблице (методом)
	/*protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>().Ignore(u=>u.Address);
	}*/
}