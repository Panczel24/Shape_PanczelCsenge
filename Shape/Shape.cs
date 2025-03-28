﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal abstract class Shape
	{

		bool isHoley;
		string color;

		public string Color { get => color; set => color = value; }

		protected Shape(string color, bool isHoley = false)
		{
			this.color = color;
			this.isHoley = isHoley;
		}


		public void MakeHoley()
		{
			isHoley = true;
		}

		public abstract double Perimeter();
		public abstract double Area();

		public override string? ToString()
		{
			return $"színe: {color} - lyukas-e: {isHoley} - kerület: {Perimeter()} - terület: {Area()}";
		}
	}
}
