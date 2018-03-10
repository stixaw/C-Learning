using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
	[TestClass]
	public class GradeBookTests
	{
		[TestMethod]
		public void ComputesHighestGrade()
		{
			// setup of test
			Gradebook book = new Gradebook();
			book.AddGrade(10);
			book.AddGrade(90);

			//Test
			GradeStatistics result = book.ComputeStatistics();

			//Assertion
			Assert.AreEqual(90, result.HighestGrade);
		}

		[TestMethod]
		public void ComputeLowestGrade()
		{
			// setup of test
			Gradebook book = new Gradebook();
			book.AddGrade(10);
			book.AddGrade(90);

			//Test
			GradeStatistics result = book.ComputeStatistics();

			//Assertion
			Assert.AreEqual(10, result.LowestGrade);
		}

		[TestMethod]
		public void ComputeAverageGrade()
		{
			// setup of test
			Gradebook book = new Gradebook();
			book.AddGrade(91);
			book.AddGrade(89.5);
			book.AddGrade(75);

			//Test
			GradeStatistics result = book.ComputeStatistics();

			//Assertion
			Assert.AreEqual(85.16, result.AverageGrade, 0.01);
		}

	}
}
