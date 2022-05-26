using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Product
	{
		public readonly string Name;

		private float _price;
		public float Price
		{
			get { return _price; }

			set { _price = value < 0 ? throw new ArgumentException() : _price = value; }
		}

		private float _weight;
		public float Weight
		{
			get { return _weight; }

			set { _weight = value < 0 ? throw new ArgumentException() : _weight = value; }
		}

		public Product()
		{ }

		public Product(string name, float price, float weight) 
		{
			Name = name;
			Price = price;
			Weight = weight;
		}
	}
}
