using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
	class Program
	{
		static void Main(string[] args)
		{
			KeyedCollectionExamples();

			//SortedDictExample();
			//SortedListExample();
			//ReadOnlyDictionary();
			//CustomEqualityUsage();
			//StringCompareDictionary();
			//ModifyDictionary();
			//GetValuesFromDictionary();
			//EnumerateDictionary();
			//ListPrimeministers();
		}

		private static void KeyedCollectionExamples()
		{
			var primeMinister = new PrimeMinisterByYearDictionary()
			{
				//initiliazer list for dictionary
				new PrimeMinister("James Callaghan", 1976),
				new PrimeMinister("Margaret Thatcher", 1979),
				new PrimeMinister("Tony Blair", 1997)
			};
			primeMinister.Add(new PrimeMinister("Gordon Brown", 2007));
			primeMinister.Add(new PrimeMinister("John Major", 1990));

			// look up by index for an Int Dictionary has to be cast as IList if it was string this would not be necessary
			var list = (IList<PrimeMinister>)primeMinister;
			Console.WriteLine("First PM is " + list[0]);

			Console.WriteLine(primeMinister[1997]);

			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm);
			}
		}

		private static void SortedDictExample()
		{
			var primeMinister = new SortedDictionary<string, PrimeMinister>
				(StringComparer.InvariantCultureIgnoreCase) // standard microsoft comparer
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};
			primeMinister.Add("GB", new PrimeMinister("Gordon Brown", 2007));
			primeMinister.Add("JM", new PrimeMinister("John Major", 1990));

			Console.WriteLine("tony is " + primeMinister["tb"]);

			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm);
			}
		}

		private static void SortedListExample()
		{
			var primeMinister = new SortedList<string, PrimeMinister>
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};
			primeMinister.Add("GB", new PrimeMinister("Gordon Brown", 2007));
			primeMinister.Add("JM", new PrimeMinister("John Major", 1990));

			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm);
			}
		}

		private static void ReadOnlyDictionary()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};

			//readonly wrapper initialization  must have collections.ObjectModel to work
			var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinister);
			foreach (var pm in pmsReadOnly)
			{
				Console.WriteLine(pm);
			}
		}

		private static void CustomEqualityUsage()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
					(new UncasedStringEqualityComparer()) // custom Comparer Class we created.
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};

			// check for TB but using tb
			Console.WriteLine(primeMinister["tb"]);
		}

		private static void StringCompareDictionary()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
				(StringComparer.InvariantCultureIgnoreCase) // allows for case insensitivity in look up by key.
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};

			// check for TB but using tb
			Console.WriteLine(primeMinister["tb"]);
		}

		private static void ModifyDictionary()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};
			// using indexer to modify and add
			primeMinister["JC"] = new PrimeMinister("Jim Callaghan", 1976);
			primeMinister["JM"] = new PrimeMinister("John Major", 1990);
			// using dictionary add method
			primeMinister.Add("GB", new PrimeMinister("Gordon Brown", 2007));

			// to remove Element
			primeMinister.Remove("GB");

			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm.Key + ", " + pm.Value);
			}
		}

		private static void GetValuesFromDictionary()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};

			//PrimeMinister pm = primeMinister["TB"];
			Console.WriteLine("value is: {0}", primeMinister["TB"].ToString() + "\r\n");

			PrimeMinister pm;
			bool found = primeMinister.TryGetValue("DC", out pm);
			if (found)
			{
				Console.WriteLine("value is: {0}", pm.ToString() + "\r\n");
			}
			else
			{
				Console.WriteLine("Value not found in dictionary");
			}
		}

		private static void EnumerateDictionary()
		{
			var primeMinister = new Dictionary<string, PrimeMinister>
			{
				//initiliazer list for dictionary
				{"JC", new PrimeMinister("James Callaghan", 1976)},
				{"MT", new PrimeMinister("Margaret Thatcher", 1979)},
				{"TB", new PrimeMinister("Tony Blair", 1997)}
			};
			//foreach (KeyValuePair<string, PrimeMinister> pm in primeMinister)
			//foreach (var pm in primeMinister.Values) // gives just values
			//foreach (var pm in primeMinister.Keys) // gives just keys
			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm.Key + ", " + pm.Value);
			}
		}

		private static void ListPrimeministers()
		{
			var primeMinister = new List<PrimeMinister>
			{
				new PrimeMinister("James Callaghan", 1976),
				new PrimeMinister("Margaret Thatcher", 1979),
				new PrimeMinister("Tony Blair", 1997)
			};

			foreach (var pm in primeMinister)
			{
				Console.WriteLine(pm);
			}
		}
	}
}
