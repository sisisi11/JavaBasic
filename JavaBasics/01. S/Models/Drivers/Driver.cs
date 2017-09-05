
using System;

public abstract class Driver
{
	protected Driver(string name, double totalTime, Car car, double fuelConsumptionPerKm)
	{
		this.Name = name;
		this.TotalTime = totalTime;
		this.Car = car;
		this.FuelConsumptionPerKm = fuelConsumptionPerKm;
		this.Speed = (car.Hp + car.Tyre.Degradation) / car.FuelAmount;
	}
	private string name;
	private double totalTime;
	private Car car;
	private double fuelConsumptionPerKm;
	private double speed;

	public double Speed
	{
		get { return speed; }
		protected set { speed = value; }
	}

	public double FuelConsumptionPerKm
	{
		get { return fuelConsumptionPerKm; }
		protected set{ fuelConsumptionPerKm = value; }
	}

	public Car Car
	{
		get { return car; }
		protected set { car = value; }
	}

	public double TotalTime
	{
		get { return totalTime; }
		protected set { totalTime = value; }
	}

	public string Name
	{
		get { return name; }
		protected set
		{
			if (value.Contains(" "))
			{
				throw new ArgumentException("Invalid driver name.");
			}
			name = value;
		}
	}

}

