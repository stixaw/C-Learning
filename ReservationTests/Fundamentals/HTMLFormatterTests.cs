using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class HTMLFormatterTests
	{
		[Test]
		public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
		{
			//Arrange
			var formatter = new HtmlFormatter();

			//Act
			var result = formatter.FormatAsBold("abc");

			//Assert with strings are case sensistive
			//Specific Assertion veryifying the exact string is what we get
			Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

			// More General Assertion if method returns error message solutions
			Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
			Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
			Assert.That(result, Does.Contain("abc"));
		}
	}
}
