using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
	class Program
	{
		static void Main(string[] args)
		{
			// Search String methods

			string str = "Extension methods have all the capabilities of regular static methods.";

			// Write the string and include the quotation marks.
			System.Console.WriteLine("\"{0}\"", str);

			// Simple comparisons are always case sensitive! 
			bool test1 = str.StartsWith("extension");
			System.Console.WriteLine("Starts with \"extension\"? {0}", test1);

			// For user input and strings that will be displayed to the end user,  
			// use the StringComparison parameter on methods that have it to specify how to match strings. 
			bool test2 = str.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
			System.Console.WriteLine("Starts with \"extension\"? {0} (ignoring case)", test2);

			bool test3 = str.EndsWith(".", System.StringComparison.CurrentCultureIgnoreCase);
			System.Console.WriteLine("Ends with '.'? {0}", test3);

			// This search returns the substring between two strings, so  
			// the first index is moved to the character just after the first string. 
			int first = str.IndexOf("methods") + "methods".Length;
			int last = str.LastIndexOf("methods");
			string str2 = str.Substring(first, last - first);
			System.Console.WriteLine("Substring between \"methods\" and \"methods\": '{0}'", str2);

			// Keep the console window open in debug mode
			System.Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		public static void GetSubString()
		{
			string str = "I love having so much fun learning C#";
			//substring
			string str1 = str.Substring(7, 2);

			//substring replace, returns a new string it doesn't replace the existing strings.
			string str2 = str.Replace("I", "We");
			Console.WriteLine(str2);

			Console.WriteLine(str1);
			Console.ReadKey();
		}

	}
}
