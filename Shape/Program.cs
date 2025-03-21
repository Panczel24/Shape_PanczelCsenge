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
				new Kocka(true, "blue", 6, 5),
				new Kör("fekete", 5)
			};
			//Kocka kocka = new Kocka(false, "red", 4, 6);
			//Shape shape3 = kocka;


        }
	}
}
