using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MotorDeport.DataBase.Configs;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
	public void Configure(EntityTypeBuilder<City> builder)
	{
		builder.HasKey(p => p.Id);
		builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
		builder.HasData
		(
			new City("Армавир", Guid.NewGuid()),
			new City ("Москва", Guid.NewGuid()),
			new City ("Краснодар", Guid.NewGuid()),
			new City ("Ростов-на-Дону", Guid.NewGuid()),
			new City ("Темрюк", Guid.NewGuid())
		);

		
	}
}