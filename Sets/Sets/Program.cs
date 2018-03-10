using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
	class Program
	{
		static void Main(string[] args)
		{
			var bigCities = new HashSet<string>
			{
				"New York",
				"Manchester",
				"Sheffield",
				"Paris"
			};
			bigCities.Add("Beijing");

			var cities = new HashSet<string>
			{
				"Sheffield",
				"Sandy",
				"New York",
				"Boulder"
			};

			//ISETMETHODSexample();
			//CaseInsensitiveHashSet();
			//HashSetUnique();
			//ListOfStringExample();
		}

		private static void ISETMETHODSexample()
		{
			var bigCities = new HashSet<string>
			{
				"New York",
				"Manchester",
				"Sheffield",
				"Paris"
			};
			bigCities.Add("Beijing");

			var cities = new HashSet<string>
			{
				"Sheffield",
				"Sandy",
				"New York",
				"Boulder"
			};

			//DiffernceWith
			//bigCities.ExceptWith(cities);
			//foreach (var city in bigCities)
			//{
			//	Console.WriteLine(city);
			//}

			// Symetric Difference
			bigCities.SymmetricExceptWith(cities);
			foreach (var city in bigCities)
			{
				Console.WriteLine(city);
			}

			//LINQ
			//var newCities = bigCities.Union(cities);
			//foreach (var city in newCities)
			//{
			//	Console.WriteLine(city);
			//}

			// ISET<T> UnionWith
			//bigCities.UnionWith(cities);
			//foreach (var city in bigCities)
			//{
			//	Console.WriteLine(city);
			//}

			// Using LINQ Intersect
			//var newCities = bigCities.Intersect(cities);
			//foreach (var city in newCities)
			//{
			//	Console.WriteLine(city);
			//}

			// ISET<T> Intersect finds cities which are a member of both collections HashSet and Array in this exmple
			//bigCities.IntersectWith(cities);  
			//foreach (var city in bigCities)
			//{
			//	Console.WriteLine(city);
			//}
		}

		private static void CaseInsensitiveHashSet()
		{
			var bigCities = new HashSet<string>
				(StringComparer.InvariantCultureIgnoreCase)
			{
				"New York",
				"Manchester",
				"Sheffield",
				"Paris"
			};
			bigCities.Add("BEIJING");
			bigCities.Add("SHEFFIELD"); // added by default because C# is case-sensitive.

			foreach (var city in bigCities)
			{
				Console.WriteLine(city);
			}
		}

		private static void HashSetUnique()
		{
			var bigCities = new HashSet<string>
			{
				"New York",
				"Manchester",
				"Sheffield",
				"Paris"
			};

			bigCities.Add("Beijing");
			// this doesn't complete because it is already a member of the set.
			bigCities.Add("Sheffield"); // returns a bool of whether it adds an item to the set this one is false

			foreach (var city in bigCities)
			{
				Console.WriteLine(city);
			}
		}

		private static void ListOfStringExample()
		{
			var bigCities = new List<string>
			{
				"New York",
				"Manchester",
				"Sheffield",
				"Paris"
			};

			// checks needed to maintain uniqueness slows down and makes list high overhead.
			if (!bigCities.Contains("Beijing"))
				bigCities.Add("Beijing");

			// attempt to add an existing element in list produces two entries for Sheffield
			if (!bigCities.Contains("Sheffield"))
				bigCities.Add("Sheffield");

			foreach (var city in bigCities)
			{
				Console.WriteLine(city);
			}
		}
	}
}
