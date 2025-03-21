using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Kör : Shape
	{
		double r;


		public Kör(string color, double r, bool isHoley = false) : base(color, isHoley)
		{
			this.r = r;
		}

		public override double Area()
		{
			return Math.Pow(r, 2) * Math.PI; ;
		}

		public override double Perimeter()
		{
			return 2 * r * Math.PI; ;
		}

		public override string? ToString()
		{
			return base.ToString() + " - kör";
		}
	}
}
