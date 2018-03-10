using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.Types
{
	[TestClass]
	public class TypeTest
	{
		[TestMethod]
		public void UsingArrays()
		{
			//setup
			float[] grades;
			grades = new float[3];

			//Action
			AddGrades(grades);

			//Assertion
			Assert.AreEqual(89.1f, grades[1]);

		}

		private void AddGrades(float[] grades)
		{
			grades[0] = 91;
			grades[1] = 89.1f;

		}

		[TestMethod]
		public void AddDate()
		{
			// Setup
			DateTime date = new DateTime(2008, 11, 1);
			DateTime date2;

			//Action
			date2 = date.AddDays(1);

			//Assertation
			Assert.AreNotEqual(date, date2);

		}

		[TestMethod]
		public void StringChange()
		{
			// Setup
			string name = "Scott ";

			// Action
			string result = name.Trim();

			//Assertation
			Assert.AreNotEqual(result, name);

		}

		[TestMethod]
		public void ValueTypesPassByValue()
		{
			// Setup
			int x = 46;
			int y = x;

			//Action
			IncrementNumber(x);

			//Assertation
			Assert.AreEqual(46, x);
		}

		private void IncrementNumber(int num)
		{
			num += 1;
			
		}

		[TestMethod]
		public void ReferenceTypesPassByValue()
		{
			//Setup
			Gradebook book1 = new Gradebook();
			Gradebook book2 = book1;

			// Action
			GiveBookAName(book1);

			//Assertation
			Assert.AreEqual(book1.Name, book2.Name);
		}

		private void GiveBookAName(Gradebook book)
		{
			book.Name = "A GradeBook";
		}


		[TestMethod]
		public void StringComparisons()
		{
			// setup
			string name1 = "Scott";
			string name2 = "scott";

			bool result = string.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);

			//Assertation
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void VariablesHoldAReference()
		{
			// Setup
			Gradebook g1 = new Gradebook();
			Gradebook g2 = g1;

			g1.Name = "Scott's grade book";

			//Assertation
			Assert.AreEqual(g1.Name, g2.Name);

		}

		[TestMethod]
		public void VariablesNewReference()
		{
			// Setup
			Gradebook g1 = new Gradebook();
			Gradebook g2 = g1;

			g1 = new Gradebook();
			g1.Name = "Scott's grade book";

			//Assertation
			Assert.AreNotEqual(g1.Name, g2.Name);

		}

		[TestMethod]
		public void VariableHoldsValue()
		{
			var x = 100;
			var y = x;

			var z = x - y;

			//Assert
			Assert.AreEqual(z, 0);
		}

		[TestMethod]
		public void IntVariableNotEqual()
		{
			var x = 100;
			var y = x;

			var z = x - y;

			//Assert
			Assert.AreNotEqual(z, x);
		}

	}
}
