using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
	public class FakeFileReader : IFileReader
	{
		public string Reader(string path)
		{
			return "";
		}
	}
}
