
using System;

public class Car
{
	public Car(int hp, double fuelAmount, Tyre tyre)
	{
		this.Hp = hp;
		this.FuelAmount = fuelAmount;
		this.Tyre = tyre;
	}

	private int hp;
	private double fuelAmount;
	private Tyre tyre;

	public Tyre Tyre
	{
		get { return tyre; }
		protected set { tyre = value; }
	}


	public double FuelAmount
	{
		get { return fuelAmount; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Driver cannot continue race");
			}

			if (value > 160)
			{
				fuelAmount = 160d;
			}
			else
			{
				fuelAmount = value;
			}
			
		}
	}


	public int Hp
	{
		get { return hp; }
		protected set{ hp = value; }
	}
		

}

