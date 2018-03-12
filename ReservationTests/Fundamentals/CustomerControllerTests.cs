using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestFixture]
	public class CustomerControllerTests
	{
		[Test]
		public void GetCustomer_IDIsZero_ReturnNotFoundObject()
		{
			//Arrange
			var controller = new CustomerController();

			//Act
			var result = controller.GetCustomer(0);

			//Assert ensures the type is not found most of the time use this
			Assert.That(result, Is.TypeOf<NotFound>());

			// isntance of means the result can be a notFound or one of its derivatives
			Assert.That(result, Is.InstanceOf<NotFound>());
		}

		[Test]
		public void GetCustomer_IDIsNotZero_ReturnOKObject()
		{
			//Arrange
			var controller = new CustomerController();

			//Act
			var result = controller.GetCustomer(1);

			//Assert
			Assert.That(result, Is.TypeOf<Ok>());
		}
	}
}
