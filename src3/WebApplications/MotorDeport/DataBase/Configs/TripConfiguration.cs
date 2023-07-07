using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MotorDeport.DataBase.Configs;

public class TripConfiguration : IEntityTypeConfiguration<Trip>
{
	public void Configure(EntityTypeBuilder<Trip> builder)
	{
		builder.HasKey(p => p.Id);
		builder.Property(p => p.Route).IsRequired().HasMaxLength(100);
		builder.Property(p => p.Time).IsRequired();
		builder.HasOne(p => p.Car).WithMany(x => x.Trips).HasForeignKey(x => x.CarId);
		builder.HasOne(p => p.Driver).WithMany(x => x.Trips).HasForeignKey(x => x.DriverId);
	}
}