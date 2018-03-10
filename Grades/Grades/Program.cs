using System;
using System.IO;
using System.Speech.Synthesis;

namespace Grades
{
	class Program
	{
		static void Main(string[] args)
		{

			Gradebook book = new Gradebook();
			// subscribers must use += or -= no longer use just = when the delegate is an event
			book.NameChanged += OnNameChanged;
			NameGradeBook(book);

			AddGrades(book);

			WriteComputeStatsResults(book);

			GetGrades(book);

			//Console.WriteLine("Highest Grade: {0}", stats.HighestGrade);
			//Console.WriteLine("Lowest Grade: {0}", stats.LowestGrade);
			//Console.WriteLine("Average Grade: {0}", stats.AverageGrade);

			//passing values to a method  you are always passing a copy of the value.
			// if reference type you pass a pointer to the reference
			// params keyword accept variable number of parameters
			//method signature name and number and types of params it takes.
		}

		private static void WriteComputeStatsResults(Gradebook book)
		{
			GradeStatistics stats = book.ComputeStatistics();
			WriteResult("Highest Grade", stats.HighestGrade);
			WriteResult("Lowest Grade", stats.LowestGrade);
			WriteResult("Average Grade", stats.AverageGrade);
			WriteResult($" Your final grade: {stats.LetterGrade}", $"{stats.Description}: ");
		}

		private static void AddGrades(Gradebook book)
		{
			book.AddGrade(91);
			book.AddGrade(89.5);
			book.AddGrade(75);
			book.AddGrade(88);
		}

		private static void GetGrades(Gradebook book)
		{
			using (StreamWriter outputFile = File.CreateText("grades.txt"))
			{
				book.WriteGrades(outputFile);
			}
		}

		private static void NameGradeBook(Gradebook book)
		{

			Console.WriteLine("Please enter the name for this gradebook.");
			var input = Console.ReadLine();
			try
			{
				book.Name = input;
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
			finally
			{
				//
			}

		}

		static void WriteResult(string desc, double result)
		{
			Console.WriteLine("{0}: {1:F2}", desc, result);
		}

		static void WriteResult(string desc, string result)
		{
			Console.WriteLine($"{desc}: {result}"); // new to C# 6
		}

		static void OnNameChanged(object sender, NameChangedEventArgs args)
		{
			Console.WriteLine($"Gradebook Name Change from {args.ExistingName} to {args.NewName}");
		}

	}
}
