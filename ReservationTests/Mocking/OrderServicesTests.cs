using System;
using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
	[TestFixture]
	public class OrderServicesTests
	{
		[Test]
		public void PlaceOrder_WhenCalled_StoreTheOrder()
		{
			//Arrange
			var storage = new Mock<IStorage>();
			var service = new OrderService(storage.Object);

			//Act
			var order = new Order();
			service.PlaceOrder(order);

			//Assert
			storage.Verify(s => s.Store(order));

		}
	}
}
