using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsStackQueues
{
	class Program
	{
		static void Main(string[] args)
		{
			QueExampleMethods();

			//LinkListExampleProgram();

			//StackingMethod();
		}

		private static void QueExampleMethods()
		{
			Queue<string> tasks = new Queue<string>();
			tasks.Enqueue("Wash the Dishes");
			tasks.Enqueue("Make the Bed");
			tasks.Enqueue("Go Shopping");
			tasks.Enqueue("Eat Dinner");

			Console.WriteLine("\r\nAll Tasks");
			foreach (var task in tasks)
			{
				Console.WriteLine(task);
			}

			Console.WriteLine("First task upt to be completed {0}", tasks.Peek());

			// removes them in the order they were added
			string completedTask = tasks.Dequeue();
			Console.WriteLine("Completed task - {0}", completedTask);

			Console.WriteLine("\r\nRemaining Tasks");
			foreach (var task in tasks)
			{
				Console.WriteLine(task);
			}
		}

		private static void StackingMethod()
		{
			Stack<string> books = new Stack<string>();

			// add method to stack is called push
			books.Push("C# Programming");
			books.Push("C# Fundamentals");
			books.Push("Python for Dummies");
			books.Push("Dogs, man's best friend");

			// peek at top element:

			Console.WriteLine("top Book is '{0}'", books.Peek());

			// remove method is pop
			string lostBook = books.Pop();
			Console.WriteLine("I removed this book '{0}'", lostBook);


			foreach (var item in books)
			{
				Console.WriteLine(item);
			}
		}

		private static void LinkListExampleProgram()
		{
			var presidents = new LinkedList<string>();
			presidents.AddLast("JFK");
			presidents.AddLast("Lindon B Johnson");
			presidents.AddLast("Richard Nixon");
			presidents.AddLast("Jimmy Carter");

			//LinkedListNode<string> nixon = presidents.Find("Richard Nixon");
			//presidents.AddAfter(nixon, "Gerald Ford");

			presidents.AddAfter(presidents.Find("Richard Nixon"), "Gerald Ford");

			//presidents.Remove("JFK"); not as efficient as removeFirst since we know it is first
			presidents.RemoveFirst();

			presidents.AddFirst("John F Kennedy");


			foreach (string item in presidents)
			{
				Console.WriteLine(item);
			}
		}
	}
}
