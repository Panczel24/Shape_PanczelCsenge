using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Haromszog : Shape
	{
		double hossz;
		double height;
		double width;
		public Haromszog(string color,double hossz,double width, double height, bool isHoley = false) : base(color, isHoley)
		{
		}

		public override double Area()
		{
			return height * hossz;
		}

		public override double Perimeter()//
		{
			return hossz+height+width;
		}

		public override string? ToString()
		{
			return base.ToString() + " - haromszog";
		}
	}
}
