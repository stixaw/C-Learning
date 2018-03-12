using System.IO;

namespace TestNinja.Mocking
{
	public interface IFileReader
	{
		string Reader(string path);
	}
	public class FileReader:IFileReader
	{
		public string Reader(string path)
		{
			var str = File.ReadAllText(path);
			return str;
		}
	}
}
