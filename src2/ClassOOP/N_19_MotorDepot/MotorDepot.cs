namespace ClassOOP.N_19_MotorDepot
{
	public class MotorDepot
	{
		public Dispatcher Dispatcherd { get; set; }
		public bool ISWork { get; private set; }
		public Driver[] Drivers { get; set; }
		public Car[] Cars { get; set; }
		public Flight[] Flights { get; set; }
	}
}