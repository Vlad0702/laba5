using System;

namespace Lab5V
{
	partial class Program
	{

		interface IProduct : IGoods
		{
			int Price { get; set; }
			void PrintPrice();
		}


		public class Product : Goods, IProduct
		{
			private int price;

			public Product(string name, int price)
			: base(name)
			{
				this.Price = price;
			}

			public Product() { }

			public int Price
			{
				get => price;
				set
				{
					if (value < 0)
					{
						throw new Exception("Цена не может быть отрицательной");
					}
					price = value;
				}
			}

		
			public void PrintPrice()
			{
				Console.WriteLine("Цена: " + this.Price);
			}
		}
	}
}
