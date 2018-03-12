using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class MathTests
	{
		private Math _math;

		// Setup
		[SetUp]
		public void SetUp()
		{
			_math = new Math();
		}

		[Test]
		public void Add_SumOfTwoIntegers3_ReturnTrue()
		{
			//Arrange
			var a = 1;
			var b = 2;

			//Act
			var result = _math.Add(a, b);

			//Assert
			//Assert.AreEqual(3, result);
			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		[TestCase(2, 1, 2)]
		[TestCase(1, 2, 2)]
		[TestCase(1, 1, 1)]
		// one test replaces 4 seperate tests with primarily the same function.
		public void Max_ReturnsTheGreaterArgument(int a, int b, int expectedResult)
		{
			//Arrange = SetUp()

			//Act
			var result = _math.Max(a, b);

			//Assert
			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		[Ignore("Refactored To TESTCASE1")]
		public void Max_FirstArgIsGreater_ReturnFirtArg()
		{
			//Arrange
			var a = 2;
			var b = 1;

			//Act
			var result = _math.Max(a, b);

			//Assert
			//Assert.AreEqual(2, result); this is mstest style
			Assert.That(result, Is.EqualTo(a));
			// Bad Assertion Example: NOT TRUSTWORTHY!!!
			//Assert.That(_math, Is.Not.Null);
		}

		[Test]
		public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
		{
			//Arrange
			var limit = 5;

			//Act
			var result = _math.GetOddNumbers(limit);

			//Assert
			//Most General Way something is returned
			Assert.That(result, Is.Not.Empty);

			//Better more specific way
			Assert.That(result.Count(), Is.EqualTo(3));

			//Check the collection
			Assert.That(result, Does.Contain(1));
			Assert.That(result, Does.Contain(3));
			Assert.That(result, Does.Contain(5));

			//Shorter way to write the contain assertions checks order too *preferred*
			Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

			// if method is supposed to sort
			Assert.That(result, Is.Ordered);

			// no duplicate items in Array
			Assert.That(result, Is.Unique);

		}

		//[Test]
		//public void Max_SecArgIsGreater_ReturnSecondArg()
		//{
		//	//Arrange
		//	var a = 1;
		//	var b = 2;

		//	//Act
		//	var result = _math.Max(a, b);

		//	//Assert
		//	//Assert.AreEqual(2, result);
		//	Assert.That(result, Is.EqualTo(b));
		//}

		//[Test]
		//public void Max_ArgumentsAreEqual_ReturnSameArgument()
		//{
		//	//Arrange
		//	var a = 2;
		//	var b = 2;

		//	//Act
		//	var result = _math.Max(a, b);

		//	//Assert
		//	//Assert.AreEqual(2, result);
		//	Assert.That(result, Is.EqualTo(2));
		//}

	}
}
