using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
//using System.Linq;

namespace Lists_Plural
{
	class Program
	{
		static void Main(string[] args)
		{
			// Collection<t> example

			//CustomCollectionExample();

			// example of ObservableColleciton<t>
			ObservableCollection<string> presidents = new ObservableCollection<string>
			{
				"George Washington",
				"Jimmy Carter",
				"Bill Clinton",
				"Ronald Reagan",
				"John Adams",
				"Barack Obama"
			};

			// EventHandler subscription
			presidents.CollectionChanged += OnCollectionChanged;

			presidents.Add("The Rock");
			presidents.Remove("The Rock");

			ListStatistics(presidents);

			//NewPresidentListAction();


			//var copy = presidents.AsReadOnly(); // first option does the same thing as the next statement.
			//var copy = new ReadOnlyCollection<string>(presidents); // requires using System.ObjectModel to work

			//BadCode(copy);  // cant be modified so copy list would be the only way to pass and be safe if the code changes the list

		}

		private static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) 
			// requires using System.Collections.Specialized;
		{

		}

		private static void NewPresidentListAction()
		{
			List<string> presidents = new List<string>
			{
				"George Washington",
				"Jimmy Carter",
				"Bill Clinton",
				"Ronald Reagan",
				"John Adams",
				"Barack Obama"
			};

			ListStatistics(presidents);
			presidents.Add("George W. Bush");
			ListStatistics(presidents);
		}

		private static void CustomCollectionExample()
		{
			NonBlankStringList lst = new NonBlankStringList();
			lst.Add("Item added at index 0");
			lst[0] = "Item changed at index 0";
			lst.Add("Item added at index 1");
			lst.Insert(2, "Item inserted at index 2");
			lst.Add(" ");

			foreach (string item in lst)
			{
				Console.WriteLine(item);
			}
		}

		private static void ListStatistics(List<string> presidents)
		{
			Console.WriteLine("The Capacity of List Presidents {0}", presidents.Capacity);
			Console.WriteLine("The count of presidents {0}", presidents.Count);
			foreach (var president in presidents)
			{
				Console.WriteLine(president);
			}
		}

		private static void ListStatistics(ObservableCollection<string> presidents)
		{
			foreach (var president in presidents)
			{
				Console.WriteLine(president);
			}
		}

		private static void BadCode(List<string> lst)
		{
			lst.RemoveAt(2);
		}
	}
}
