
public class EnduranceDriver : Driver
{
	private const double fuelConsumptionPerKm = 1.5d;

	public EnduranceDriver(string name, double totalTime, Car car) : base(name, totalTime, car, fuelConsumptionPerKm)
	{
	}
}

