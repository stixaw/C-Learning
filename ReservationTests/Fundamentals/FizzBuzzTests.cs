using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void GetOutput_NumberReturned()
		{
			//Arrange
			int num = 1;

			//Act
			var result = FizzBuzz.GetOutput(num);

			//Assert
			Assert.That(result, Is.EqualTo(num.ToString()));
		}

		[Test]
		public void GetOutput_NumberModular5_ReturnBuzz()
		{
			//Arrange
			int num = 5;

			//Act
			var result = FizzBuzz.GetOutput(num);

			//Assert
			Assert.That(result, Is.EqualTo("Buzz"));
		}

		[Test]
		public void GetOutput_NumberModular3_ReturnFizz()
		{
			//Arrange
			int num = 3;

			//Act
			var result = FizzBuzz.GetOutput(num);

			//Assert
			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void GetOutput_NumberModular3And5_ReturnFizzBuzz()
		{
			//Arrange
			int num = 15;

			//Act
			var result = FizzBuzz.GetOutput(num);

			//Assert
			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}
	}
}
