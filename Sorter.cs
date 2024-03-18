using Socks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
	internal class Sorter
	{
		static List<Cloth> clothes = new List<Cloth>();

		public void Initialize()
		{
			clothes.Add(new Cloth(0, "sock", "46", "blue"));
			clothes.Add(new Cloth(1, "sock", "46", "blue"));
			clothes.Add(new Cloth(2, "sock", "46", "blue"));
			clothes.Add(new Cloth(-7, "sock", "46", "green"));
			clothes.Add(new Cloth(3, "sock", "45", "red"));
			clothes.Add(new Cloth(4, "sock", "42", "green"));
			clothes.Add(new Cloth(4, "sock", "42", "green"));
			clothes.Add(new Cloth(4, "sock", "42", "green"));
			clothes.Add(new Cloth(15, "shirt", "42", "green"));
		}

		public void Sort()
		{
			for (var i = 0; i < clothes.Count; i++)
			{
				for (var j = i + 1; j < clothes.Count; j++) // pair item cannot be i or before
				{
					if (clothes[i].Equals(clothes[j]))
					{
						var a = clothes[i];
						var b = clothes[j];

						clothes.Remove(a);
						clothes.Remove(b);
						i = i - 1; // re start searching at current i (i-1+1 with next loop) cannot have pair item before
						break;
					}
				}
			}

			foreach (var cloth in clothes.Where(c => c.Name == "sock" ))
			{
				Console.WriteLine(cloth);
			}

			////single is great :
			//Console.WriteLine("Is the sock 45 alone and in there? : ");
			//var q = clothes.Where(x => x.Size=="45").Single();
			//if (q == null)
			//	Console.WriteLine("No single sock in 45");
			//else { Console.WriteLine("Here is one : " + q.Id); }



			//Console.WriteLine("number of socks : ");
			//string query2 = clothes.Select(x=>x).Where(x=>x.Name =="sock").ToString();
			//Console.WriteLine(query2);



		}
	}
}


//Console.WriteLine("number of clothes : ");
//int query = clothes.Count();
//Console.WriteLine(query);

//Console.WriteLine("largest ID : ");
//int query1 = clothes.Max(x => x.Id);
//Console.WriteLine(query1);

//Console.WriteLine("Min ID : ");
//Console.WriteLine(clothes.Min(x => x.Id));

//Console.WriteLine("Sck num 3 : ");
//Console.WriteLine(clothes.ElementAt(3).Size + " " + clothes.ElementAt(3).Color);
//Cloth thisOne = clothes.ElementAt(3);


//Console.WriteLine("first sock color at 46 : ");
//var query = clothes.Where(x =>x.Size == "46").First();
//Console.WriteLine(query.Id + " " + query.Color);