
public class AggresiveDriver : Driver
{
	private const double fuelConsumptionPerKm = 2.7d;
	private const double MultiplierSpeed = 1.3d;


	public AggresiveDriver(string name, double totalTime, Car car ) : base(name, totalTime, car, fuelConsumptionPerKm)
	{
		this.Speed *= MultiplierSpeed;
	}
}

