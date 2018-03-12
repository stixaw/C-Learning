using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
	[TestClass]
	public class ReservationTests
	{
		[TestMethod]
		public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
		{
			//Arrange
			var reservation = new Reservation();

			//ACT
			var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CanBeCancelledBy_MadeByUserCancelling_ReturnsTrue()
		{
			//Arrange
			var user = new User();
			var reservation = new Reservation { MadeBy = user };

			//Act
			var result = reservation.CanBeCancelledBy(user);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CanBeCancelledBy_UserCancelling_ReturnsFalse()
		{
			//Arrange
			var user = new User { IsAdmin = false };
			var reservation = new Reservation { MadeBy = new User() };

			//Act
			var result = reservation.CanBeCancelledBy(user);

			//Assert
			Assert.IsFalse(result);
		}
	}
}
