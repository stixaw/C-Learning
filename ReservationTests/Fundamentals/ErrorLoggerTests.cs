using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class ErrorLoggerTests
	{
		private ErrorLogger _logger;

		[SetUp]
		public void SetUp()
		{
			_logger = new ErrorLogger();
		}

		[Test]
		public void Log_WhenCalledShouldSetTheLastErrorProperty()
		{

			//Act
			_logger.Log("a");

			//Assert
			Assert.That(_logger.LastError, Is.EqualTo("a"));

		}

		[Test]
		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		public void Log_WhenCalledWithEmtpyString_ShouldThrowArgumentNullException(string error)
		{

			//Assert
			//Assert.Throws(typeof(ArgumentNullException),() => { _logger.Log(error); });
			Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
			//Assert.That(() => _logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>);
		}

		[Test]
		// Testing ErrorLogged?.Invoke(this, Guid.NewGuid());
		public void Log_ValidError_RaisedErrorLoggedEvent()
		{
			//Arrange
			var id = Guid.Empty;
			//subscribe to that event before acting
			_logger.ErrorLogged += (sender, args) => { id = args; };

			//Act
			_logger.Log("a");

			//Assert
			Assert.That(id, Is.Not.EqualTo(Guid.Empty));
		}

	}
}
