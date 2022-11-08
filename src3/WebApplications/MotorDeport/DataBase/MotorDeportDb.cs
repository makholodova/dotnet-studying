namespace MotorDeport.DataBase;

public static class MotorDeportDb
{
	static MotorDeportDb()
	{
		Dispatcher = "Роман";
		Drivers = new List<Driver>();
		Drivers.Add(new Driver("Иван", true, Guid.NewGuid()));
		Drivers.Add(new Driver("Саша", true, Guid.NewGuid()));
		Drivers.Add(new Driver("Костя", true, Guid.NewGuid()));
		Drivers.Add(new Driver("Денис", true, Guid.NewGuid()));
		Drivers.Add(new Driver("Глеб", true, Guid.NewGuid()));
		Cars = new List<Car>();
		Cars.Add(new Car(true, "Hyundai", 521, Guid.NewGuid()));
		Cars.Add(new Car(true, "Toyota", 842, Guid.NewGuid()));
		Cars.Add(new Car(true, "BMW", 757, Guid.NewGuid()));
		Cars.Add(new Car(true, "Kia", 152, Guid.NewGuid()));
		Cars.Add(new Car(true, "Mazda", 138, Guid.NewGuid()));
		Cars.Add(new Car(true, "Suzuki", 456, Guid.NewGuid()));
		Cars.Add(new Car(true, "Ford", 621, Guid.NewGuid()));
		Trips = new List<Trip>();
	}

	public static string Dispatcher { get; set; }
	public static List<Driver> Drivers { get; set; }
	public static List<Car> Cars { get; set; }

	public static List<Trip> Trips { get; set; }
}