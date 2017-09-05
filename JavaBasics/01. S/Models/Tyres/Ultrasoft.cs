
public class Ultrasoft : Tyre
{
	public Ultrasoft(string name, double hardness, double grip) : base(name, hardness)
	{
		this.Grip = grip;
	}

	private double grip;

	public double Grip
	{
		get { return grip; }
		private set { grip = value; }
	}

}

