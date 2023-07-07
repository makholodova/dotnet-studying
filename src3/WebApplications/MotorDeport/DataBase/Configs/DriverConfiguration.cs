using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MotorDeport.DataBase.Configs;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
	public void Configure(EntityTypeBuilder<Driver> builder)
	{
		builder.HasKey(p => p.Id);
		builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
		builder.Property(p => p.IsWork).IsRequired();
	}
}