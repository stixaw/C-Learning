using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class DemeritPointsCalculatorTests
	{
		private DemeritPointsCalculator _calc;

		[SetUp]
		public void SetUp()
		{
			_calc = new DemeritPointsCalculator();
		}

		[Test]
		[TestCase(-1)]
		[TestCase(301)]
		public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
		{

			//Assert
			Assert.Throws(typeof(ArgumentOutOfRangeException),() => { _calc.CalculateDemeritPoints(speed); });

		}

		[Test]
		[TestCase(0, 0)]
		[TestCase(64, 0)]
		[TestCase(65, 0)]
		[TestCase(66, 0)]
		[TestCase(71, 1)]
		[TestCase(75, 2)]
		public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
		{

			//Act
			var result = _calc.CalculateDemeritPoints(speed);

			//Assert
			Assert.That(result, Is.EqualTo(expectedResult));

		}

	}
}
