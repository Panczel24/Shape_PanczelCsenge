﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Kocka : Rectangle
	{
		public override double Height { get => Width; set => Height = value; }
		public override double Width { get => Height; set => Width = value; }


		public Kocka(bool isHoley, string color, double height, double width) : base(isHoley, color, height, width)
		{
		}

		public override string? ToString()
		{
			return "négyzet - "+ base.ToString();
		}
	}
}
