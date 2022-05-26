using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Buy
	{
		public List<Product> Products = new List<Product>();

		public void Add(Product product) 
		{
			Products.Add(product);
		}
		public void Add(string name, float price, float weight)
		{
			Products.Add(new Product(name, price, weight));
		}
		public void Remove() 
		{
			Products.RemoveAt(0);
		}
		public void Remove(int index)
		{
			Products.RemoveAt(index);
		}
		public void Remove(Product product) 
		{
			Products.Remove(product);
		}
		public int GetQuantityOfGoods()
		{
			return Products.Count;
		}

		public float GetPriceOfAllProducts() 
		{
			float priceOfAllProduct = 0;
			for (int i = 0; i < GetQuantityOfGoods(); i++) 
			{
				priceOfAllProduct += Products[i].Price;
			}
			return priceOfAllProduct;
		}

		public float GetWeightOfAllProducts() 
		{
			float weightOfAllProducts = 0;
			for (int i = 0; i < GetQuantityOfGoods(); i++)
			{
				weightOfAllProducts += Products[i].Weight;
			}
			return weightOfAllProducts;
		}
	}
}
