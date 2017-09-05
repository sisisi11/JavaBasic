
using System;

// Пробвай с различни accesers на конструкторите и на set-ърите!! Private, protected!! Това най-много може да ти гърми!!

// Floated-point number може да е double, float, decimal и затова може да не ти дава точки





public class Engine
{
	public void Run()
	{
		var car = new Car(12,160, new Hard("Gumichka", 100, 100));
		var tyre = new Hard("ailqk", 12, 12);
		tyre.Degradation -= 100;
		tyre.Degradation -= 5;
		Console.WriteLine();
	}
}

