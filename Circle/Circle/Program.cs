using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
	class Program
	{
		static void Main(string[] args)
		{
			//object (instance) ->> object is when you create a space in memory and you start assigning values to the blueprint you created in the other class
			CircleClass c = new CircleClass(55, "Black");

			Console.WriteLine("Input a radius: ");
				c.Radius = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine($"Area is {Math.Round(c.GetArea(),2)}, Perimeter is {Math.Round(c.GetPerimeter(), 2)}");//these output the same. The $ is used to avoid concatination.
			Console.WriteLine("Area is: " + Math.Round(c.GetArea(),2)+", Permimerter is: "+Math.Round(c.GetPerimeter(),2));

			Console.WriteLine("Enter a  key to terminate.");
			Console.ReadKey();
		}
	}
}
