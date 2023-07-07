using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MotorDeport.DataBase.Configs;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
	public void Configure(EntityTypeBuilder<Car> builder)
	{
		builder.HasKey(p => p.Id);
		builder.Property(p => p.Model).IsRequired().HasMaxLength(100);
		builder.Property(p => p.Number).IsRequired().HasMaxLength(3);
		builder.Property(p => p.IsWork).IsRequired();
		//builder.HasMany(p => p.Trips).WithOne(p => p.Car).HasForeignKey(p => p.CarId);
	}
}