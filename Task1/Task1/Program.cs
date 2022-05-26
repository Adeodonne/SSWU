using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Buy buy = new Buy();
			buy.Add(new Product("Laptop", 12300, 1.412f));
			buy.Add(new Product("Fridge", 1200, 50.312f));
			buy.Add(new Product("Smartphone", 3000, 0.5f));
			buy.Add(new Product("Mouse", 2300, 0.2f));
			Check check = new Check();
			check.PrintCheck(buy);
		}
	}
}
