using System;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
	[TestFixture]
	public class StackTests
	{
		private Stack<string> stack;

		[SetUp]
		public void SetUp()
		{
			stack = new Stack<string>();
		}

		[Test]
		public void Push_ArgIsNull_ThrowArgumentOutOfRangeException()
		{

			//Assert
			Assert.That(() => stack.Push(null), Throws.ArgumentNullException);

		}

		[Test]
		public void Push_ValidArg_AddToStack()
		{
			//Arrange
			var obj = "A";

			//Act
			stack.Push(obj);

			//Assert
			Assert.That(stack.Count, Is.EqualTo(1));

		}

		[Test]
		public void Count_EmtpyStack_ReturnZero()
		{
			//Assert
			Assert.That(stack.Count, Is.EqualTo(0));
		}

		[Test]
		public void Pop_EmptyStack_ThrowInvalidOperationException()
		{

			//Assert
			Assert.That(() => stack.Pop(), Throws.InvalidOperationException);

		}

		[Test]
		public void Pop_StackWithFewObjects_ReturnTopOfStack()
		{
			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");

			//Act
			var result = stack.Pop();

			//Assert
			Assert.That(result, Is.EqualTo("c"));
		}

		[Test]
		public void Pop_StackWithFewObjects_RemovesObjFromTopOfStack()
		{
			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");

			//Act
			stack.Pop();

			//Assert
			Assert.That(stack.Count == 2);

		}

		[Test]
		public void Peek_EmptyStack_ThrowInvalidOperationException()
		{

			//Assert
			Assert.That(() => stack.Peek(), Throws.InvalidOperationException);

		}

		public void Peek_StackWithObjs_ReturnObjectOnTopOfTheStack()
		{
			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");

			//Act
			var result = stack.Peek();

			//Assert
			Assert.That(result, Is.EqualTo("c"));

		}

		public void Peek_StackWithObjs_DoesNotRemoveObjOnTopofStack()
		{
			//Arrange
			stack.Push("a");
			stack.Push("b");
			stack.Push("c");

			//Act
			stack.Peek();

			//Assert
			Assert.That(stack.Count == 3);

		}
	}
}
