
using System;

public abstract class Tyre
{
	protected Tyre(string name, double hardness)
	{
		this.Name = name;
		this.Hardness = hardness;
		this.Degradation = 100;
	}
	private string name;
	private double hardness;
	private double degradation;

	public double Degradation
	{
		get { return degradation; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Driver cannot continue race.");
			}
			degradation = value;
		}
	}

	public double Hardness
	{
		get { return hardness; }
		protected set { hardness = value; }
	}

	public string Name
	{
		get { return name; }
		protected set { name = value; }
	}

}

