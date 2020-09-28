using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V
{
	partial class Program
	{
		
		delegate MilkProduct[] Search(MilkProduct[] milkProducts);
		delegate void Message();

		static void Main(string[] args)
		{
			MilkProduct milk = new MilkProduct("Milk", 20, new DateTime(2020, 9, 30));
			PrintMilkProductInfo(milk);

			void PrintMilkProductInfo(MilkProduct milkProduct)
			{
				Message mes = milkProduct.PrintName;
				mes += milkProduct.PrintPrice;
				mes += milkProduct.PrintShelfLife;
				mes();
				Console.WriteLine();
			}

			MilkProduct[] milkProducts = new MilkProduct[5]
			{
				new MilkProduct("Milk", 20, new DateTime(2020, 10, 29)),
				new MilkProduct("Milk", 10, new DateTime(2020, 9, 27)),
				new MilkProduct("Yogurt", 7, new DateTime(2020, 9, 26)),
				new MilkProduct("Yogurt", 10, new DateTime(2020, 10, 30)),
				new MilkProduct("Cheese", 30, new DateTime(2020, 9, 1))
			};

			Search search = MilkProduct.GetExpiredMilkProducts;
			MilkProduct[] expiredMilkProducts = search(milkProducts);
			Console.WriteLine("===========\n\nПросроченные молочные товары:\n");
			foreach (MilkProduct p in expiredMilkProducts)
			{
				PrintMilkProductInfo(p);
			}
			Console.ReadKey();
		}
	}
}
