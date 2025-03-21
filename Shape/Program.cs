using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rec = new Rectangle(false, "red", 2, 3);
            Console.WriteLine(rec.ToString());

			Shape[] shapes =
			{
				rec,
				new Kocka(true, "blue", 5, 5),
				new Kör("fekete", 5),
				new Rectangle(true, "szürke", 6, 9),
				new Kör("lila", 10), 
			};
			for (int i = 0; i < shapes.Length; i++)
			{
				Console.WriteLine(shapes[i].ToString());
			}
			Console.WriteLine();
            //Kocka kocka = new Kocka(false, "red", 4, 6);
            //Shape shape3 = kocka;
            Lyuk(shapes);
            Console.WriteLine();

            Console.WriteLine(kell(5, 10).ToString());
            Console.WriteLine();
            Legnagyobb(shapes);




        }
		static void Lyuk(Shape[] shapes)
		{
			for (int i = 0; i < shapes.Length; i++)
			{
				if (shapes[i].Area()> shapes[i].Perimeter() )
				{
					shapes[i].MakeHoley();
					Console.WriteLine($" a {shapes[i].ToString()} lyukas lett");
				}
			}
        }

		static Shape kell(double hpssz, double masik)
		{ 
			if(hpssz ==  masik )
			{

				return new Kocka(false, "szürke", 5, 5);
			}
			return new Rectangle(true, "fehér", 5, 10);
		}

		static void Legnagyobb(Shape[] shapes)
		{
			Shape alma = shapes[0];
			for (int i = 0;i < shapes.Length;i++)
			{
				if (shapes[i].Area()> alma.Area())
				{
					alma = shapes[i];
				}
			}
            Console.WriteLine(alma.ToString());
        }


	}
}
