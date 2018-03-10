using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyStrings
{
	class ModifyStrings
	{
		static void Main()
		{
			string str = "The quick brown fox jumped over the fence";
			System.Console.WriteLine(str);

			char[] chars = str.ToCharArray();
			int animalIndex = str.IndexOf("fox");
			if (animalIndex != -1)
			{
				chars[animalIndex++] = 'c';
				chars[animalIndex++] = 'a';
				chars[animalIndex] = 't';
			}

			string str2 = new string(chars);
			System.Console.WriteLine(str2);

			// Keep the console window open in debug mode
			System.Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
	}
}
