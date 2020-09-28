using System;

namespace Lab5V
{
	partial class Program
	{
		public interface IToy
		{
			string MadeIn { get; set; }

			void PrintCountry();
		}

		public class Toy : Goods, IToy
		{
			private string madeIn;
			public Toy(string name, string madeIn)
				: base(name)
			{
				this.MadeIn = madeIn;
			}

			public Toy() { }

			public string MadeIn { get => madeIn; set => madeIn = value; }

			public void PrintCountry()
			{
				Console.WriteLine(this.MadeIn);
			}

			public static Toy[] GetMadeIn(Toy[] toys, string coutry)   //получить все игрушки, сделанные в стране country
			{
				int count = 0;
				for (int i = 0; i < toys.Length; i++)
				{
					if (toys[i].MadeIn.ToLower() == coutry.ToLower())
					{
						count++;
					}
				}

				if (count == 0)
				{
					return null;
				}

				Toy[] result = new Toy[count];
				count = 0;
				for (int i = 0; i < toys.Length; i++)
				{
					if (toys[i].MadeIn.ToLower() == coutry.ToLower())
					{
						result[count++] = toys[i];
					}
				}

				return result;
			}
		}
	}
}
