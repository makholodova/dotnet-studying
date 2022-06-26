namespace ClassOOP.N_19_MotorDepot
{
	public class MotorDepotEntryPoint : IEntryPoint
	{
		public void Start()
		{
			var motorDeport = new MotorDepot();

			var dispatcher = new Dispatcher(motorDeport);
			motorDeport.Dispatcherd = dispatcher;
			
			
		}
	}
}