using System;

namespace Lab5V
{
	partial class Program
	{
		interface IMilkProduct : IProduct
		{
			DateTime ShelfLife { get; set; }
			void PrintShelfLife();
		}

		public class MilkProduct : Product, IMilkProduct
		{
			private DateTime shelfLife;          //срок годности

			public MilkProduct(string name, int price, DateTime shelfLife)
				: base(name, price)
			{
				this.ShelfLife = shelfLife;
			}

			public MilkProduct() { }

			public DateTime ShelfLife { get => shelfLife; set => shelfLife = value; }

			public void PrintShelfLife()
			{
				Console.WriteLine("Срок годности: " + this.shelfLife);
			}

			public static MilkProduct[] GetExpiredMilkProducts(MilkProduct[] milkProducts)   //получить все просроченные молочные продукты
			{
				int count = 0;
				for (int i = 0; i < milkProducts.Length; i++)
				{
					if (milkProducts[i].ShelfLife < DateTime.Now)
					{
						count++;
					}
				}

				if (count == 0)
				{
					return null;
				}

				MilkProduct[] result = new MilkProduct[count];
				count = 0;
				for (int i = 0; i < milkProducts.Length; i++)
				{
					if (milkProducts[i].ShelfLife < DateTime.Now)
					{
						result[count++] = milkProducts[i];
					}
				}

				return result;
			}
		}
	}
}
