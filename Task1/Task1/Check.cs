using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Check
	{
		public void PrintCheck(Buy buy) 
		{
			for (int i = 0; i < buy.Products.Count; i++) 
			{
				Console.WriteLine(i + ". " + buy.Products[i].Name + "\nPrice: " + buy.Products[i].Price + "\nWeight: " + buy.Products[i].Weight);
			}
		}
	}
}
