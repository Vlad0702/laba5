using System;

namespace Lab5V
{
	partial class Program
	{


		interface IGoods
		{
			string Name { get; set; }
			void PrintName();
		}

		public class Goods: IGoods 
		{
			private string name;
			public Goods(string name)
			{
				this.Name = name;
			}

			public Goods() { Name = "Неизвестно"; }

			public string Name { get => name; set => name = value; }

			public void PrintName()
			{
				Console.WriteLine("Название товара:" + this.Name);
			}
		}
	}
}
