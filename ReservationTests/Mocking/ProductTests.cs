using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
	[TestFixture]
	public class ProductTests
	{
		[Test]
		public void GetPrice_GoldCustomer_Apply30PercentDiscount()
		{
			//Arrange
			var product = new Product { ListPrice = 100};

			//Act
			var result = product.GetPrice(new Customer { IsGold = true });

			//Assert
			Assert.That(result, Is.EqualTo(70));
		}

		[Test]
		public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
		{
			//Arrange
			var customer = new Mock<ICustomer>();
			customer.Setup(c => c.IsGold).Returns(true);

			var product = new Product { ListPrice = 100 };

			//Act
			var result = product.GetPrice(customer.Object);

			//Assert
			Assert.That(result, Is.EqualTo(70));
		}
	}
}
