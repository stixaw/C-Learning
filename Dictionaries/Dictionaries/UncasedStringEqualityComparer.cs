using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
	public class UncasedStringEqualityComparer : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return x.ToUpper() == y.ToUpper();
		}

		public int GetHashCode(string obj)
		{
			return obj.ToUpper().GetHashCode();
		}
	}
}
