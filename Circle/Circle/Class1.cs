using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
	//access modifiers - are the level of access to the class fields
	class CircleClass
	{
		//constructer - same name as class, is used to create an instance of a class.
		public CircleClass(double radius, string colour)
		{
			Radius = radius;
			Colour = colour;
		}

		public string Colour { get; set; }
		public double Radius { get; set; } //property

		public string GetRadius()
		{
			return "Radius: " + Radius;
		}

		public double GetArea()
		{
			return Math.PI * Radius * Radius;
		}

		public double GetPerimeter()
		{
			return (2 * Math.PI) * Radius;
		}

	}
}
