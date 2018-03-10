using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
	class Program
	{
		static void Main(string[] args)
		{

			string str1 = "apple";
			string str2 = string.Copy(str1);

			Console.WriteLine("Reference: " + ReferenceEquals(str1, str2));
			Console.WriteLine("Operator: " + AreStringsEqualOp(str1, str2));
			Console.WriteLine("Method: " + AreStringsEqualMethod(str1, str2));
			Console.WriteLine("Static: " + object.Equals(str1, str2));


			//Console.WriteLine("Operator: " + AreIntsEqualOp(3, 3));
			//Console.WriteLine("Method: " + AreIntsEqualMethod(3, 3));

		}

		static bool AreIntsEqualOp(int x, int y)
		{
			return x == y;
		}

		static bool AreIntsEqualMethod(int x, int y)
		{
			return x.Equals(y);
		}

		static bool AreStringsEqualOp(string x, string y)
		{
			return x == y;
		}

		static bool AreStringsEqualMethod(string x, string y)
		{
			return x.Equals(y);
		}
	}
}
